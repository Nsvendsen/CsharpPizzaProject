using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaAflevering.Models.Enteties;

namespace PizzaAflevering.Models.PizzaModel
{
    public class PizzaMaker
    {
        private List<Pizza> pizzas;

        public void addPizza(Pizza pizza)
        {
            pizzas.Add(pizza);
        }
        public void removePizza(Pizza pizza)
        {
            pizzas.Remove(pizza);
        }
    }
}