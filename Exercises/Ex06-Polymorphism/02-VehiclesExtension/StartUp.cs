using System;
using System.Collections.Generic;

class StartUp
{
	static void Main(string[] args)
	{
		string[] carArgs = Console.ReadLine().Split();
		string[] truckArgs = Console.ReadLine().Split();
		string[] busArgs = Console.ReadLine().Split();

		double carFuelQuantity = double.Parse(carArgs[1]);
		double carFuelConsumption = double.Parse(carArgs[2]);
		double carTankCapacity = double.Parse(carArgs[3]);
		double truckFuelQuantity = double.Parse(truckArgs[1]);
		double truckFuelConsumption = double.Parse(truckArgs[2]);
		double truckTankCapacity = double.Parse(truckArgs[3]);
		double busFuelQuantity = double.Parse(busArgs[1]);
		double busFuelConsumption = double.Parse(busArgs[2]);
		double busTankCapacity = double.Parse(busArgs[3]);

		try
		{
			Car car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
			Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
			Bus bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

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
								case "Bus":
									bus.Drive(parameter);
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
								case "Bus":
									bus.Refuel(parameter);
									break;
							}
							break;
						case "DriveEmpty":
							bus.DriveEmpty(parameter);
							break;
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			Console.WriteLine(car);
			Console.WriteLine(truck);
			Console.WriteLine(bus);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}