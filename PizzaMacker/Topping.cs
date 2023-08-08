using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMacker
{
    internal class Topping : Ingredient
    {
        Ingredient ingredient;
        public Topping(Ingredient ing, string name, decimal cost) : base(name, cost) { ingredient = ing; }
        public Topping(Souse sous, string name, decimal cost) : base(name, cost) { ingredient = sous; }
        public override decimal GetCost() => ingredient.GetCost() + Cost;
        public override string GetName() => ingredient.GetName() + ",\n" + Name;
    }
}
