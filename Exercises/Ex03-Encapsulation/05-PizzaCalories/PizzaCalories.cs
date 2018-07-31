using System;

class PizzaCalories
{
    static void Main(string[] args)
    {
        string[] pizzaInfo = Console.ReadLine().Split();
        string[] doughInfo = Console.ReadLine().Split();

        try
        {
            string pizzaName = pizzaInfo[1];
            string doughType = doughInfo[1];
            string doughBakingTechnique = doughInfo[2];
            double doughWeight = double.Parse(doughInfo[3]);
            Dough dough = new Dough(doughType, doughBakingTechnique, doughWeight);
            Pizza pizza = new Pizza(pizzaName, dough);
            string toppingInput;

            while ((toppingInput = Console.ReadLine()) != "END")
            {
                string[] toppingInfo = toppingInput.Split();
                string toppingType = toppingInfo[1];
                double toppingWeight = double.Parse(toppingInfo[2]);
                Topping topping = new Topping(toppingType, toppingWeight);
                pizza.AddTopping(topping);
            }

            Console.WriteLine(pizza);
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
            Environment.Exit(0);
        }

    }
}