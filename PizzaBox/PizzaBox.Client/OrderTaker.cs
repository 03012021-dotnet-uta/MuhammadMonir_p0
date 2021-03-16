using PizzaBox.DAL;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.Client
{
    class OrderTaker
    {
        private IRepository mc;
      
        private List<Crust> crusts;
        private int totalPremadePiza;
        private int totalCustomizedPizza;
        private int totalCrusts;
        private int totalToppings;
        private APizza selectedPizza;
        private List<OrderDetail> newOrderDetails;
        private List<OrderDetail> orderDetails;
        private List<Order> orders;
        private List<PremadePizzaTopping> premadePizzaToppings;
        private List<CustomizedPizzaTopping> customizedPizzaToppings;
        private List<PremadePizza> premadePizzas;
        private List<Topping> toppings;
        private List<Size> sizes;
        private float thisPizzaPrice = 0;


        private Utility utility;

        public OrderTaker()
        {

            IRepository mc = new DBRepository();

            totalPremadePiza = mc.GetPremadePizzas().Count;
            totalCrusts = mc.GetCrusts().Count;
            totalToppings = mc.GetToppings().Count;
            sizes = mc.GetSizes();
            orderDetails = mc.GetOrderDetails();
            orders = mc.GetOrders();
            premadePizzaToppings = mc.GetPremadePizzaTopping();
            customizedPizzaToppings = mc.GetCustomizedPizzaTopping();
            premadePizzas = mc.GetPremadePizzas();
            utility = new();
            crusts = mc.GetCrusts();
            toppings = mc.GetToppings();
            newOrderDetails = new List<OrderDetail>();

        }

        public void BuildOrder(int customerID, int storeID)
        {

           
            int checkout = 0;
            float[] mf = new float[4];
            mf[0] = 1.0f;
            mf[1] = sizes[1].PriceMultiplicationFactor;
            mf[2] = sizes[2].PriceMultiplicationFactor;
            mf[3] = sizes[3].PriceMultiplicationFactor;

            List<int> pizzaCodes = new() { 0 };
            do
            {
                foreach (var p in premadePizzas)
                {

                    Console.Write("\t\t****** {0} ******\n", p.Name);
                    Crust crust = crusts.Find(c => c.ID == p.CrustID);
                    Console.WriteLine("Having or made by  {0}", crust.Name);
                    Console.Write("Toppings including ");
                    float price = crust.BasePrice;
                    List<PremadePizzaTopping> pt = premadePizzaToppings.FindAll(x => x.PremadePizzaID == p.ID);
                    Topping topping1;
                    foreach (var p1 in pt)
                    {
                        topping1 = toppings.FirstOrDefault(g => g.ID == p1.ToppingID);
                        Console.Write(topping1.Name + " ");
                        price += topping1.BasePrice;
                    }

                    thisPizzaPrice = price;

                    Console.WriteLine("\nPrices:  \tSmall = ${0}\n\t\tMedium = ${1}" +
                        "\n\t\tLarge = ${2}\n\t\tX_Large = ${3} \n", price, (price * mf[1]).ToString("n2"), (price * mf[2]).ToString("n2"), (price * mf[3]).ToString("n2"));
                    Console.WriteLine("Pizza Code <{0}>", p.ID);
                    pizzaCodes.Add(p.ID);
                }

                int choice = 0;
                do
                {
                    Console.WriteLine("Enter <Pizza Code> to select premade pizza or <0> to make your own pizza");

                    choice = Convert.ToInt32(Console.ReadLine());


                    if (choice == 0)
                    {
                        //CustomizedPizza selectedPizza = new CustomizedPizza();
                        selectedPizza = CreatPizza();
                        float price = thisPizzaPrice; // int price2 = utility.CalculatePrice(selectedPizza, 1);
                        Console.WriteLine("\nPrices:  \tSmall = ${0}\n\t\tMedium = ${1}" +
                       "\n\t\tLarge = ${2}\n\t\tX_Large = ${3} \n", price, (price * mf[1]).ToString("n2"), (price * mf[2]).ToString("n2"), (price * mf[3]).ToString("n2"));

                    }

                    else if (pizzaCodes.Contains(choice))
                    {
                        //PremadePizza selectedPizza = new PremadePizza();
                        selectedPizza = premadePizzas.Find(pz => pz.ID == choice);
                    }

                    else
                        Console.WriteLine("Invalid choice, pleae enter again");
                   
                } while (!pizzaCodes.Contains(choice));

                int size = 1;
                int totalSizes = sizes.Count;
                do
                {
                    Console.Write("Enter Size:\n(Enter <1> for small, <2> for Medium, <3> for Large and <4> for X-large Size) ");
                    size = Convert.ToInt32(Console.ReadLine());
                    if (size < 0 || size > totalSizes)
                        Console.WriteLine("Wrong choice... Please enter values greater than 0 and less than {0}", totalSizes + 1);
                } while (size < 0 || size > totalSizes);



                Console.Write("-----------\nEnter Quantity: ");
                int qty = Convert.ToInt32(Console.ReadLine());

                float fprice =  thisPizzaPrice*mf[size-1];

                //order item detail
               
                Console.WriteLine("\nYour item: {0}\t{1}(size)\tQty:{2}\t{3}/per item\tSubTotal = ${4}",
                    selectedPizza.Name, sizes.Find(sz => sz.ID == size).Name, qty, fprice.ToString("n2"), (qty * fprice).ToString("n2"));
                selectedPizza.Name += " " + sizes.Find(sz => sz.ID == size).Name;
                AddToOrder(selectedPizza, size, qty, fprice);
                Console.WriteLine("\nItem Saved....\n\nEnter <0> to checkout or anyother number to add more items");
                checkout = Convert.ToInt32(Console.ReadLine());

            } while (checkout != 0);

            ShowandSaveOrder(customerID, 2);


        }

        public void ShowandSaveOrder(int customerID, int storeID)
        {
            Console.WriteLine("*********Your Complete Order*************");
            Order newOrder = new();
            float total = 0;
            foreach (var ord in newOrderDetails)
            {
                total += ord.Price * ord.Quantity;
                Console.WriteLine("{0} X {1}\t{2} per pizza\t\tSubtotal = {3}",
                ord.Quantity, ord.ProductName, ord.Price.ToString("n2"), (ord.Quantity* ord.Price).ToString("n2"));
            }
            Console.WriteLine("\t----------\nTotal = {0}\n\tTaxes = {1}\n\tGrand Total = {2}", total.ToString("n2"), (0.1 * total).ToString("n2"), (1.1 * total).ToString("n2"));
            
            newOrder.CustomerID = customerID;
            newOrder.StoreID = storeID;
            newOrder.OrderDate = DateTime.Now.Date;
            newOrder.StoreAmount = total;
            newOrder.TaxAmount = (float)(total * 1.1);
            DBRepository db = new();
            int newOrderID = db.SaveOrder(newOrder);
            foreach (var ord in newOrderDetails)
            {
                ord.OrderID = newOrderID;
                db.SaveOrderDetail(ord);
            }
            //orders.Add(newOrder);

        }




        private void AddToOrder(APizza aPizza, int size, int qty, float price)
        {
            //Console.WriteLine("aPizza Prop ID ={0}\tName = {1}", aPizza.ID, aPizza.Name);
            OrderDetail cd = new();
            cd.ProductID = aPizza.ID;
            cd.ProductName = aPizza.Name;
            cd.Quantity = qty;
            cd.Price = price;
            newOrderDetails.Add(cd);
            //orderDetails.Add(od);

        }

        private CustomizedPizza CreatPizza()
        {
            CustomizedPizza customizedPizza = new();
            //display crust options
            Console.WriteLine("Step 1/2 ------ Choose Crust");
            foreach (var cr in crusts)
                Console.WriteLine("{0} {1} \tEnter {0} to select this crust", cr.ID, cr.Name);
            int crustChoice = 0;
            do
            {
                crustChoice = Convert.ToInt32(Console.ReadLine());
                if (crustChoice < 1 || crustChoice > totalCrusts)
                    Console.WriteLine("Wrong Choice... Please enter number greater than 0 and less than {0}", totalCrusts); ;
            } while (crustChoice < 1 || crustChoice > totalCrusts);

            customizedPizza.CrustID = crustChoice;

            //display Toppings
            Console.WriteLine("Step 2/2 ------ Choose upto 3 toppings");
            foreach (var tp in toppings)
                Console.WriteLine("{0} {1} \tEnter {0} to select this topping", tp.ID, tp.Name);
            int toppingChoice;
            int[] toppingArray = new int[3];
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter Topping{0} choice", i);
                do
                {
                    toppingChoice = Convert.ToInt32(Console.ReadLine());
                    if (toppingChoice < 1 || toppingChoice > totalToppings)
                        Console.WriteLine("Wrorng Choice.... Please enter number greater than 1 and less than {0}", totalToppings + 1);

                } while (toppingChoice < 1 || toppingChoice > totalToppings);

                customizedPizza.CustomizedPizzaToppings.Add(new CustomizedPizzaTopping() { ToppingID = toppingChoice });
                toppingArray[i-1] = toppingChoice;
            }
            float[] mf = new float[4];
            mf[0] = 1.0f;
            mf[1] = sizes[1].PriceMultiplicationFactor;
            mf[2] = sizes[2].PriceMultiplicationFactor;
            mf[3] = sizes[3].PriceMultiplicationFactor;




            float price = CalculatePrice(customizedPizza.CrustID, toppingArray);
            Console.WriteLine("\nPrices:  \tSmall = ${0}\n\t\tMedium = ${1}" +
            "\n\t\tLarge = ${2}\n\t\tX_Large = ${3} \n", price, (price * mf[1]).ToString("n2"), (price * mf[2]).ToString("n2"), (price * mf[3]).ToString("n2"));
            Console.WriteLine("Enter a name to save this for future reference");
            customizedPizza.Name = Console.ReadLine();
            thisPizzaPrice = price;
            //utility.PrintPizza(customizedPizza);
            return customizedPizza;
        }

        public float CalculatePrice(int crustID, int[] toppings1)
        {


            float price = crusts.Find(x => x.ID == crustID).BasePrice;
            foreach (var tpg in toppings1)
            {
                price += toppings.Find(x => x.ID == tpg).BasePrice;
            }

            return price;
        }

    }
}

