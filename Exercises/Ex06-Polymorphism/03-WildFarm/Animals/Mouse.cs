using System;

public class Mouse : Mammal
{
	private const double WeightPerEat = 0.1;

	public Mouse(string name, double weight, string livingRegion)
		: base(name, weight, livingRegion)
	{
		base.wheightPerEat = WeightPerEat;
	}

	public override void AskForFood()
	{
		Console.WriteLine("Squeak");
	}

	public override void Eat(Food food)
	{
		switch (food.GetType().Name)
		{
			case "Meat":
			case "Seeds":
				throw new WrongFoodException(this.GetType().Name, food.GetType().Name);
			default:
				base.Eat(food);
				break;
		}
	}

	public override string ToString()
	{
		string result = base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
		return result;
	}
}