using System;

public abstract class Vehicle : IVehicle
{
	public Vehicle(double fuelQuantity, double fuelConsumption)
	{
		this.FuelQuantity = fuelQuantity;
		this.FuelConsumption = fuelConsumption;
		this.DistanceTravelled = 0;
	}

	public double FuelQuantity { get; protected set; }

	public double FuelConsumption { get; protected set; }

	public double DistanceTravelled { get; protected set; }

	public virtual void Drive(double distance)
	{
		this.DistanceTravelled += distance;
		this.FuelQuantity -= distance * this.FuelConsumption;
		string message = $"{this.GetType().Name} travelled {distance} km";
		Console.WriteLine(message);
	}

	public virtual void Refuel(double quantity)
	{
		this.FuelQuantity += quantity;
	}

	public override string ToString()
	{
		string message = $"{this.GetType().Name}: {this.FuelQuantity:F2}";
		return message;
	}
}