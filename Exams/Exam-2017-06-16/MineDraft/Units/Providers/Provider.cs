using System.Text;

public abstract class Provider : Unit
{
	private double energyOutput;

	protected Provider(string id, double energyOutput)
		:base(id)
	{
		this.EnergyOutput = energyOutput;
	}

	public double EnergyOutput
	{
		get { return energyOutput; }
		private set
		{
			Validator.EnergyOutput(value);
			energyOutput = value;
		}
	}

	public override string ToString()
	{
		StringBuilder builder = new StringBuilder();

		builder.AppendLine($"{this.Type} Provider - {this.Id}")
			.AppendLine($"Energy Output: {this.EnergyOutput}");

		string message = builder.ToString().TrimEnd();
		return message;
	}
}