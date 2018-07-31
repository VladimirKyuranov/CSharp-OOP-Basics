public abstract class Driver
{
	protected Driver(string name, Car car, double fuelConsumption)
	{
		this.Name = name;
		this.Car = car;
		this.FuelConsumptionPerKm = fuelConsumption;
		this.TotalTime = 0;
	}

	public string Name { get; }

	public double TotalTime { get; private set; }

	public Car Car { get; }

	public double FuelConsumptionPerKm { get; }

	public virtual double Speed => (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;
}