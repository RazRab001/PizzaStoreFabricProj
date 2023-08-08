using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        List<Pizza> pizzas;
        Dough dough;
        Souse souse;
        Topping topping;
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
        public static void addDoughToPizza(string dough)
        {
            foreach(Dough d in doughs)
            {
                if(d.Dough.GetName() == dough) { this.dough = d; }
            }
        }
        public static void addSouseToPizza(string souse)
        {
            foreach(Souse s in souses)
            {
                if(s.Dough.GetName() == souse) { this.souse = new Souse(dough, s.GetName(), s.GetCost() }
            }
        }
        public static void addToppingToPizza(string topping)
        {
            foreach(Topping t in toppings)
            {
                if(t.Topping.GetName() == topping)
                {
                    if(this.topping != null)
                    {
                        this.topping = new Topping(topping, t.GetName(), t.GetCost());
                    }
                    else
                    {
                        this.topping = new Topping(this.souse, t.GetName(), t.GetCost());
                    }
                }
            }
        }
        public static void addNewPizza(string pizzaName, Topping topping)
        {
            pizzas.Add(new Pizza(pizzaName, topping));
        }
    }
}
