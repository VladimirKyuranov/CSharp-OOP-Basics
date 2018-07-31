public class Truck : Vehicle
{
	private const double AdditionalConsumption = 1.6;

	public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
		: base(fuelQuantity, fuelConsumption + AdditionalConsumption, tankCapacity)
	{
	}

	public override void Drive(double distance)
	{
		if (this.FuelQuantity < distance * this.FuelConsumption)
		{
			throw new TruckOutOfFuelException();
		}


		base.Drive(distance);
	}

	public override void Refuel(double quantity)
	{
		const double FuelLoss = 0.05;

		base.Refuel(quantity);

		this.FuelQuantity -= quantity * FuelLoss;
	}
}