using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMacker
{
    public class Dough : Ingredient
    {
        public Dough(string name, decimal cost) : base(name, cost) {}
        public override decimal GetCost() => Cost;
        public override string GetName() => Name;
    }
}
