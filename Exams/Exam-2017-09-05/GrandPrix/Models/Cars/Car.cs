using System;

public class Car
{
	private const double FuelTankCapacity = 160;

	private double fuelAmount;

	public Car(int hp, double fuelAmount, Tyre tyre)
	{
		this.Hp = hp;
		this.FuelAmount = fuelAmount;
		this.Tyre = tyre;
	}

	public int Hp { get; }

	public double FuelAmount
	{
		get { return fuelAmount; }
		private set
		{
			Validator.CheckFuel(value);
			fuelAmount = Math.Min(value, FuelTankCapacity);
		}
	}

	public Tyre Tyre { get; private set; }

	public void ChangeTyre(Tyre tyre)
	{
		this.Tyre = tyre;
	}

	public void Refuel(double fuelAmount)
	{
		this.FuelAmount += fuelAmount;
	}
}