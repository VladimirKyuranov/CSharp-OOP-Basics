using System;

public class Owl : Bird
{
	private const double WeightPerEat = 0.25;

	public Owl(string name, double weight, double wingSize) 
		: base(name, weight, wingSize)
	{
		base.wheightPerEat = WeightPerEat;
	}

	public override void AskForFood()
	{
		Console.WriteLine("Hoot Hoot");
	}

	public override void Eat(Food food)
	{
		if (food.GetType().Name != "Meat")
		{
			throw new WrongFoodException(this.GetType().Name, food.GetType().Name);
		}

		base.Eat(food);
	}
}