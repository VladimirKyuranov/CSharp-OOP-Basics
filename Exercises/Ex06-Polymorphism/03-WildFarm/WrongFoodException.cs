using System;

public class WrongFoodException : Exception
{
	private string animalType;
	private string foodType;

	public WrongFoodException(string animalType, string foodType)
	{
		this.animalType = animalType;
		this.foodType = foodType;
	}

	public override string Message => $"{this.animalType} does not eat {this.foodType}!";
}