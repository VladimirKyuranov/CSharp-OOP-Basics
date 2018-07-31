public class Car : Vehicle
{
	private const double AdditionalConsumption = 0.9;

	public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
		: base(fuelQuantity, fuelConsumption + AdditionalConsumption, tankCapacity)
	{
	}

	public override void Drive(double distance)
	{
		if (this.FuelQuantity < distance * this.FuelConsumption)
		{
			throw new CarOutOfFuelException();
		}

		base.Drive(distance);
	}
}