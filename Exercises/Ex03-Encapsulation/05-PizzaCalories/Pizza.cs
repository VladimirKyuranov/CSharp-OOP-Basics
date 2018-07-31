using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private string name;
    private Dough dough;
    private List<Topping> toppings;

    public string Name
    {
        get { return name; }
        set
        {
            Validation.PizzaName(value);
            name = value;
        }
    }

    public Pizza(string name, Dough dough)
    {
        Name = name;
        this.dough = dough;
        toppings = new List<Topping>();
    }

    public void AddTopping(Topping topping)
    {
        Validation.ToppicsCount(toppings);
        toppings.Add(topping);
    }

    private double CalculateCalories()
    {
        double calories = dough.TotalCalories() + toppings.Sum(t => t.TotalCalories());

        return calories;
    }

    public override string ToString()
    {
        return $"{name} - {CalculateCalories():F2} Calories.";
    }
}