using System;

public class Tiger : Feline
{
	private const double WeightPerEat = 1;

	public Tiger(string name, double weight, string livingRegion, string breed)
		: base(name, weight, livingRegion, breed)
	{
		base.wheightPerEat = WeightPerEat;
	}

	public override void AskForFood()
	{
		Console.WriteLine("ROAR!!!");
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