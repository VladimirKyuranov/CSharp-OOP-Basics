using System;
using System.Collections.Generic;

public class Validation
{
    public static void FlourType(string flourType)
    {
        switch (flourType.ToLower())
        {
            case "white":
            case "wholegrain":
                break;
            default:
                throw new ArgumentException("Invalid type of dough.");
        }
    }

    public static void BakingTechnique(string bakingTechnique)
    {
        switch (bakingTechnique.ToLower())
        {
            case "crispy":
            case "chewy":
            case "homemade":
                break;
            case "domashno":
                throw new ArgumentException("Invalid type of dough.");
            default:
                throw new ArgumentException("Invalid baking technique");
        }
    }

    public static void Weight(double weight, double minWeight, double maxWeight, string name)
    {
        if (weight < minWeight || weight > maxWeight)
        {
            throw new ArgumentException($"{name} weight should be in the range [{minWeight}..{maxWeight}].");
        }
    }

    public static void ToppingType(string type)
    {
        switch (type.ToLower())
        {
            case "meat":
            case "veggies":
            case "cheese":
            case "sauce":
                break;
            default:
                throw new ArgumentException($"Cannot place {type} on top of your pizza.");
        }
    }

    public static void PizzaName(string name)
    {
        if (name?.Trim().Length < 1 || name?.Trim().Length > 15)
        {
            throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
        }
    }

    public static void ToppicsCount(List<Topping> toppings)
    {
        if (toppings.Count == 10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
    }
}