
namespace PizzaMacker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dough dough = new Dough("Tie dought", 0.78m);
            Souse souse = new Souse(dough, "Tomato souse", 0.2m);
            Topping topping = new Topping(souse, "Cheese gouda", 0.19m);
            Topping topping1 = new Topping(topping, "Cheese gouda", 0.19m);
            Pizza pizza = new Pizza("Margaritta",topping1);
            pizza.display();
        }
    }
}