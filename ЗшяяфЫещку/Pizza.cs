using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMacker
{
    internal class Pizza
    {
        Topping Topping { get; set; }
        string Name { get; set; }
        public Pizza(string name, Topping topping)
        {
            Topping = topping;
            Name = name;
        }
        public void display()
        {
            Console.WriteLine(Name +" :");
            Console.WriteLine(Topping.GetName() + "\nPrice: " + Topping.GetCost());
        }
    }
}
