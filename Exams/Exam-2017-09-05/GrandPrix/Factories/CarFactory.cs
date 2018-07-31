using System.Collections.Generic;
using System.Linq;

public class CarFactory
{
	public Car CreateCar(List<string> arguments)
	{
		TyreFactory tyreFactory = new TyreFactory();
		int hp = int.Parse(arguments[0]);
		double fuelAmount = double.Parse(arguments[1]);
		List<string> tyreArgs = arguments.Skip(2).ToList();
		Tyre tyre = tyreFactory.CreateTyre(tyreArgs);
		Car car = new Car(hp, fuelAmount, tyre);

		return car;
	}
}