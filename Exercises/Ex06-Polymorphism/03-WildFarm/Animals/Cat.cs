using System;

public class Cat : Feline
{
	private const double WeightPerEat = 0.3;

	public Cat(string name, double weight, string livingRegion, string breed)
		: base(name, weight, livingRegion, breed)
	{
		base.wheightPerEat = WeightPerEat;
	}

	public override void AskForFood()
	{
		Console.WriteLine("Meow");
	}

	public override void Eat(Food food)
	{
		switch (food.GetType().Name)
		{
			case "Fruit":
			case "Seeds":
				throw new WrongFoodException(this.GetType().Name, food.GetType().Name);
			default:
				base.Eat(food);
				break;
		}
	}
}