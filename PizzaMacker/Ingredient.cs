using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMacker
{
    public abstract class Ingredient
    {
        protected string Name { get; init; }
        protected decimal Cost { get; init; }
        public Ingredient(string name, decimal cost) { Name = name; Cost = cost; }
        public abstract string GetName();
        public abstract decimal GetCost();
    }
}
