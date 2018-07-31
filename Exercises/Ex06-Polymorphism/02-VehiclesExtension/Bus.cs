using System;

public class Bus : Vehicle, IEmptyDriveable
{
	private const double AirConditionerConsumption = 1.4;
	private double emptyFuelConsumption;

	public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
		: base(fuelQuantity, fuelConsumption + AirConditionerConsumption, tankCapacity)
	{
		emptyFuelConsumption = fuelConsumption;
	}

	public override void Drive(double distance)
	{
		if (this.FuelQuantity < distance * this.FuelConsumption)
		{
			throw new BusOutOfFuelException();
		}

		base.Drive(distance);
	}

	public void DriveEmpty(double distance)
	{
		if (this.FuelQuantity < distance * this.emptyFuelConsumption)
		{
			throw new BusOutOfFuelException();
		}

		this.DistanceTravelled += distance;
		this.FuelQuantity -= distance * this.emptyFuelConsumption;
		string message = $"{this.GetType().Name} travelled {distance} km";
		Console.WriteLine(message);
	}
}