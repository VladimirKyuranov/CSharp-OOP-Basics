using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> bag;

    public string Name
    {
        get { return name; }
        set
        {
            Validation.EmptyName(value);
            name = value;
        }
    }

    public decimal Money
    {
        get { return money; }
        set
        {
            Validation.NegativeMoney(value);
            money = value;
        }
    }

    public Person(string name, decimal money)
    {
        bag = new List<Product>();
        Name = name;
        Money = money;
    }

    public void BuyProduct(Product product)
    {
        if (product.Cost <= money)
        {
            bag.Add(product);
            money -= product.Cost;
            Console.WriteLine($"{name} bought {product.Name}");
        }
        else
        {
            Console.WriteLine($"{name} can't afford {product.Name}");
        }
    }

    public override string ToString()
    {
        string bougthProducts = "Nothing bought";

        if (bag.Count > 0)
        {
            bougthProducts = string.Join(", ", bag);
        }
        return $"{name} - {bougthProducts}";
    }
}