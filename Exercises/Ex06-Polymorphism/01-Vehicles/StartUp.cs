using System;
using System.Collections.Generic;

class StartUp
{
	static void Main(string[] args)
	{
		string[] carArgs = Console.ReadLine().Split();
		string[] truckArgs = Console.ReadLine().Split();

		double carFuelQuantity = double.Parse(carArgs[1]);
		double carFuelConsumption = double.Parse(carArgs[2]);
		double truckFuelQuantity = double.Parse(truckArgs[1]);
		double truckFuelConsumption = double.Parse(truckArgs[2]);

		IVehicle car = new Car(carFuelQuantity, carFuelConsumption);
		IVehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption);

		int vehiclesCount = int.Parse(Console.ReadLine());

		for (int counter = 0; counter < vehiclesCount; counter++)
		{
			string[] commandArgs = Console.ReadLine().Split();

			string command = commandArgs[0];
			string vehicleType = commandArgs[1];
			double parameter = double.Parse(commandArgs[2]);

			try
			{
				switch (command)
				{
					case "Drive":
						switch (vehicleType)
						{
							case "Car":
								car.Drive(parameter);
								break;
							case "Truck":
								truck.Drive(parameter);
								break;
						}
						break;
					case "Refuel":
						switch (vehicleType)
						{
							case "Car":
								car.Refuel(parameter);
								break;
							case "Truck":
								truck.Refuel(parameter);
								break;
						}
						break;
				}
			}
			catch (OutOfFuelException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		Console.WriteLine(car);
		Console.WriteLine(truck);
	}
}