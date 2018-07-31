using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
	private List<Harvester> harvesters;
	private List<Provider> providers;
	private HarvesterFactory harvesterFactory;
	private ProviderFactory providerFactory;
	private string mode;
	private double totalEnergyStored;
	private double totalMinedOre;

	public DraftManager()
	{
		harvesters = new List<Harvester>();
		providers = new List<Provider>();
		harvesterFactory = new HarvesterFactory();
		providerFactory = new ProviderFactory();
		mode = "Full";
		totalEnergyStored = 0;
		totalMinedOre = 0;
	}

	public string RegisterHarvester(List<string> arguments)
	{
		try
		{
			Harvester harvester = harvesterFactory.CreateHarvester(arguments);
			harvesters.Add(harvester);
			string message = $"Successfully registered {harvester.Type} Harvester - {harvester.Id}";
			return message;
		}
		catch (ArgumentException argEx)
		{
			return argEx.Message;
		}
	}

	public string RegisterProvider(List<string> arguments)
	{
		try
		{
			Provider provider = providerFactory.CreateProvider(arguments);
			providers.Add(provider);
			string message = $"Successfully registered {provider.Type} Provider - {provider.Id}";
			return message;
		}
		catch (ArgumentException argEx)
		{
			return argEx.Message;
		}
	}

	public string Day()
	{
		double dayEnergiProvided = providers.Sum(p => p.EnergyOutput);
		totalEnergyStored += dayEnergiProvided;
		double dayEnergyRequired, dayMinedOre;

		switch (this.mode)
		{
			case "Full":
				dayEnergyRequired = harvesters.Sum(h => h.EnergyRequirement);
				dayMinedOre = harvesters.Sum(h => h.OreOutput);
				break;
			case "Half":
				dayEnergyRequired = harvesters.Sum(h => h.EnergyRequirement) * 0.6;
				dayMinedOre = harvesters.Sum(h => h.OreOutput) * 0.5;
				break;
			default:
				dayEnergyRequired = 0;
				dayMinedOre = 0;
				break;
		}

		double realDayMinedOre = 0;

		if (totalEnergyStored >= dayEnergyRequired)
		{
			realDayMinedOre = dayMinedOre;
			totalMinedOre += dayMinedOre;
			totalEnergyStored -= dayEnergyRequired;
		}

		StringBuilder builder = new StringBuilder();

		builder.AppendLine("A day has passed.")
			.AppendLine($"Energy Provided: {dayEnergiProvided}")
			.AppendLine($"Plumbus Ore Mined: {realDayMinedOre}");

		string message = builder.ToString().TrimEnd();
		return message;
	}

	public string Mode(List<string> arguments)
	{
		this.mode = arguments[0];
		string message = $"Successfully changed working mode to {mode} Mode";
		return message;
	}

	public string Check(List<string> arguments)
	{
		string id = arguments[0];
		Unit unit = (Unit)harvesters.FirstOrDefault(h => h.Id == id) ?? providers.FirstOrDefault(p => p.Id == id);
		string message = $"No element found with id - {id}";

		if (unit != null)
		{
			message =  unit.ToString();
		}

		return message;
	}

	public string ShutDown()
	{
		StringBuilder builder = new StringBuilder();

		builder.AppendLine("System Shutdown")
			.AppendLine($"Total Energy Stored: {totalEnergyStored}")
			.AppendLine($"Total Mined Plumbus Ore: {totalMinedOre}");

		string message = builder.ToString().TrimEnd();
		return message;
	}
}