public class Truck : Vehicle
{
	private const double AdditionalConsumption = 1.6;

	public Truck(double fuelQuantity, double fuelConsumption)
		: base(fuelQuantity, fuelConsumption + AdditionalConsumption)
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
		const double FuelPercentage = 0.95;

		base.Refuel(quantity * FuelPercentage);
	}
}