public class AggressiveDriver : Driver
{
	private const double SpeedIncrease = 1.3;

	public AggressiveDriver(string name, Car car) 
		: base(name, car, 2.7)
	{
	}

	public override double Speed => base.Speed * SpeedIncrease;
}