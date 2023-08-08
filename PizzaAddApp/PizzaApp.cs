using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaMacker;

namespace PizzaAddApp
{
    internal abstract class PizzaApp
    {
        List<Dough> doughs;
        List<Ingredient> souses;
        List<Ingredient> toppings;
        public PizzaApp()
        {
            doughs = new List<Dough>();
            souses = new List<Ingredient>();
            toppings = new List<Ingredient>();
        }
        public static void addNewDough(string name, decimal cost)
        {
            doughs.Add(new Dough(name, cost));
        }
        public static void addNewSouse(string name, decimal cost)
        {
            souses.Add(new Ingredient(name, cost));
        }
        public static void addNewTopping(string name, decimal cost)
        {
            toppings.Add(new Ingredient(name, cost));
        }
        public static
    }
}
