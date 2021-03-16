using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.DAL
{
    public class Utility
    {
        private List<Crust> Crusts;
        private List<Topping> Toppings;
        private List<Size> Sizes;

        public Utility()
        {
            IRepository mc = new DBRepository();
            Crusts = mc.GetCrusts();
            Toppings = mc.GetToppings();
            Sizes = mc.GetSizes();

        }
        //public void PrintPizza(APizza mypizza)
        //{
        //    Console.WriteLine("*********{0}********", mypizza.Name);
        //    Console.WriteLine("Crust: {0}", Crusts.Find(cr => cr.ID == mypizza.CrustID).Name);
        //    List<PremadePizzaTopping> pt = PizzaToppings.FindAll(rec => rec.PremadePizzaID == mypizza.ID);
        //    foreach (var t in pt)
        //        Console.WriteLine("Topping: {0}", Toppings.Find(tp => tp.ID == t.PremadePizzaID).Name);
        //}

        public float CalculatePrice(int crustID, int[] toppings)
        {

            
            float price = Crusts.Find( x => x.ID == crustID).BasePrice;
            foreach (var topping in toppings)
            {
                price += Toppings.Find(x => x.ID == topping).BasePrice;
            }

           return price;
        }
    }
}
