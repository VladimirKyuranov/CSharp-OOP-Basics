using System;

public class Dog : Mammal
{
	private const double WeightPerEat = 0.4;

	public Dog(string name, double weight, string livingRegion)
		: base(name, weight, livingRegion)
	{
		base.wheightPerEat = WeightPerEat;
	}

	public override void AskForFood()
	{
		Console.WriteLine("Woof!");
	}

	public override void Eat(Food food)
	{
		if (food.GetType().Name != "Meat")
		{
			throw new WrongFoodException(this.GetType().Name, food.GetType().Name);
		}

		base.Eat(food);
	}

	public override string ToString()
	{
		string result = base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
		return result;
	}
}