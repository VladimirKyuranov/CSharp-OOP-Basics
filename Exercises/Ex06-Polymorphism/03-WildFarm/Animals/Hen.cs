using System;

public class Hen : Bird
{
	private const double WeightPerEat = 0.35;

	public Hen(string name, double weight, double wingSize)
		: base(name, weight, wingSize)
	{
		base.wheightPerEat = WeightPerEat;
	}

	public override void AskForFood()
	{
		Console.WriteLine("Cluck");
	}

	public override void Eat(Food food)
	{
		base.Eat(food);
	}
}