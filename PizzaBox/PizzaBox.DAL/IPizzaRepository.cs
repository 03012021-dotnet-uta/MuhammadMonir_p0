using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox.DAL
{
    public interface IPizzaRepository 
    {
        List<PremadePizza> GetPremadePizzas();
        List<CustomizedPizza> GetCustomizedPizzas();
        List<Crust> GetCrusts();
        List<Topping> GetToppings();
        List<Size> GetSizes();
        List<PremadePizzaTopping> GetPremadePizzaTopping();
        List<CustomizedPizzaTopping> GetCustomizedPizzaTopping();

        int SaveCustomizedPizza(APizza cp);
        

    }
}
