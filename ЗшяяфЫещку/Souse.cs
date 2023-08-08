using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMacker
{
    internal class Souse : Ingredient
    {
        Dough Dough;
        public Souse(Dough dough, string name, decimal cost) : base(name, cost) { Dough = dough; }
        public override decimal GetCost() => Dough.GetCost() + Cost;
        public override string GetName() => Dough.GetName() + ",\n" + Name;
    }
}
