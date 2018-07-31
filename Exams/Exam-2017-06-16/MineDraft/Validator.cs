using System;

public class Validator
{
	public static void OreOutput(double oreOutput)
	{
		if (oreOutput < 0)
		{
			throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
		}
	}

	public static void EnergyRequirement(double energyRequirement)
	{
		if (energyRequirement < 0 || energyRequirement > 20000)
		{
			throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
		}
	}

	public static void EnergyOutput(double energyOutput)
	{
		if (energyOutput < 0 || energyOutput > 10000)
		{
			throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
		}
	}
}