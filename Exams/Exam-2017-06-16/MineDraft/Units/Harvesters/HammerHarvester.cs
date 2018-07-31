public class HammerHarvester : Harvester
{
	private const int OreOutputIncrease = 3;
	private const int energyRequirementIncrease = 2;

	public HammerHarvester(string id, double oreOutput, double energyRequirement)
		: base(id, oreOutput * OreOutputIncrease, energyRequirement * energyRequirementIncrease)
	{
	}

	public override string Type => "Hammer";
}