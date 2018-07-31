public abstract class Animal
{
	protected double wheightPerEat;

	public Animal(string name, double weight)
	{
		this.Name = name;
		this.Weight = weight;
		this.FoodEaten = 0;
	}

	public string Name { get; protected set; }

	public double Weight { get; protected set; }

	public int FoodEaten { get; protected set; }

	public abstract void AskForFood();

	public virtual void Eat(Food food)
	{
		this.Weight += this.wheightPerEat * food.Quantity;
		this.FoodEaten += food.Quantity;
	}

	public override string ToString()
	{
		string result = $"{this.GetType().Name} [{this.Name}, ";
		return result;
	}
}