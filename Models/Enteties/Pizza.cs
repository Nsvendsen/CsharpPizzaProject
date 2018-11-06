using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAflevering.Models.Enteties
{
    public class Pizza
    {
        private int pizzaNr;
        private String pizzaName;
        private List<String> pizzaTopping;
        private double price;

        public Pizza(int pizzaNr, string pizzaName, List<string> pizzaTopping, double price)
        {
            this.pizzaNr = pizzaNr;
            this.pizzaName = pizzaName;
            this.pizzaTopping = pizzaTopping;
            this.price = price;
        }
    }
}