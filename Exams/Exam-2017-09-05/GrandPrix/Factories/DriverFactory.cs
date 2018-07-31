using System;
using System.Collections.Generic;
using System.Linq;

public class DriverFactory
{
	public Driver CreateDriver(List<string> arguments)
	{
		CarFactory carFactory = new CarFactory();
		string type = arguments[0];
		string name = arguments[1];
		List<string> carArgs = arguments.Skip(2).ToList();
		Car car = carFactory.CreateCar(carArgs);

		switch (type)
		{
			case "Endurance":
				return new EnduranceDriver(name, car);
			case "Aggressive":
				return new AggressiveDriver(name, car);
			default:
				throw new ArgumentException();
		}
	}
}