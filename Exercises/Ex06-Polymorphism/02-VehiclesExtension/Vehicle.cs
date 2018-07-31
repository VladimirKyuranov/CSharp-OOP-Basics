using System;

public abstract class Vehicle : IVehicle
{
	protected double fuelQuantity;

	public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
	{
		this.TankCapacity = tankCapacity;
		this.FuelQuantity = fuelQuantity;
		this.FuelConsumption = fuelConsumption;
		this.DistanceTravelled = 0;
	}

	public double FuelQuantity
	{
		get { return fuelQuantity; }
		protected set
		{
			if (value > TankCapacity)
			{
				fuelQuantity = 0;
			}
			else
			{
				fuelQuantity = value;
			}
		}
	}

	public double FuelConsumption { get; protected set; }

	public double TankCapacity { get; protected set; }

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
		if (quantity <= 0)
		{
			throw new NegativeFuelException();
		}

		if (FuelQuantity + quantity > TankCapacity)
		{
			throw new TankOverflowException(quantity);
		}

		this.FuelQuantity += quantity;
	}

	public override string ToString()
	{
		string message = $"{this.GetType().Name}: {this.FuelQuantity:F2}";
		return message;
	}
}