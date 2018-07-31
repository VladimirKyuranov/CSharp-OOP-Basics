public class PressureProvider : Provider
{
	private const double EnergyOutputIncrease = 1.5;

	public PressureProvider(string id, double energyOutput) 
		: base(id, energyOutput * EnergyOutputIncrease)
	{
	}

	public override string Type => "Pressure";
}