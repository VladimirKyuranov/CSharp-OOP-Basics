using System;
using System.Collections.Generic;

class StartUp
{
	static void Main(string[] args)
	{
		List<Animal> farm = new List<Animal>();
		List<Food> foods = new List<Food>();
		string input;

		while ((input = Console.ReadLine()) != "End")
		{
			string[] animalArgs = input.Split();
			string[] foodArgs = Console.ReadLine().Split();

			string animalType = animalArgs[0];
			string animalName = animalArgs[1];
			double animalWeight = double.Parse(animalArgs[2]);
			Animal animal = null;

			string foodType = foodArgs[0];
			int foodQuantity = int.Parse(foodArgs[1]);
			Food food = null;

			switch (animalType)
			{
				case "Hen":
					double henWingSize = double.Parse(animalArgs[3]);
					animal = new Hen(animalName, animalWeight, henWingSize);
					break;
				case "Owl":
					double owlWingSize = double.Parse(animalArgs[3]);
					animal = new Owl(animalName, animalWeight, owlWingSize);
					break;
				case "Mouse":
					string mouseLivingRegion = animalArgs[3];
					animal = new Mouse(animalName, animalWeight, mouseLivingRegion);
					break;
				case "Cat":
					string catLivingRegion = animalArgs[3];
					string catBreed = animalArgs[4];
					animal = new Cat(animalName, animalWeight, catLivingRegion, catBreed);
					break;
				case "Dog":
					string dogLivingRegion = animalArgs[3];
					animal = new Dog(animalName, animalWeight, dogLivingRegion);
					break;
				case "Tiger":
					string tigerLivingRegion = animalArgs[3];
					string tigerBreed = animalArgs[4];
					animal = new Tiger(animalName, animalWeight, tigerLivingRegion, tigerBreed);
					break;
			}

			switch (foodType)
			{
				case "Meat":
					food = new Meat(foodQuantity);
					break;
				case "Fruit":
					food = new Fruit(foodQuantity);
					break;
				case "Seeds":
					food = new Seeds(foodQuantity);
					break;
				case "Vegetable":
					food = new Vegetable(foodQuantity);
					break;
			}

			farm.Add(animal);
			foods.Add(food);
		}

		int foodIndex = 0;

		foreach (var animal in farm)
		{
			try
			{
				animal.AskForFood();
				animal.Eat(foods[foodIndex++]);
			}
			catch (WrongFoodException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		farm.ForEach(a => Console.WriteLine(a));
	}
}