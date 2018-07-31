using System.Text;

public abstract class Harvester : Unit
{
	private double oreOutput;
	private double energyRequirement;

	protected Harvester(string id, double oreOutput, double energyRequirement)
		:base (id)
	{
		this.OreOutput = oreOutput;
		this.EnergyRequirement = energyRequirement;
	}

	public double OreOutput
	{
		get { return oreOutput; }
		private set
		{
			Validator.OreOutput(value);
			oreOutput = value;
		}
	}

	public double EnergyRequirement
	{
		get { return energyRequirement; }
		protected set
		{
			Validator.EnergyRequirement(value);
			energyRequirement = value;
		}
	}

	public override string ToString()
	{
		StringBuilder builder = new StringBuilder();

		builder.AppendLine($"{this.Type} Harvester - {this.Id}")
			.AppendLine($"Ore Output: {this.OreOutput}")
			.AppendLine($"Energy Requirement: {this.EnergyRequirement}");

		string message = builder.ToString().TrimEnd();
		return message;
	}
}