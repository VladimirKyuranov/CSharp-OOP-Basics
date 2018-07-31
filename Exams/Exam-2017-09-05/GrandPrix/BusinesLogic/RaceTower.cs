using System;
using System.Collections.Generic;
using System.Linq;

public class RaceTower
{
	private int lapsNumber, trackLength;
	private int currentLap = 0;
	private string weather = "Sunny";
	private DriverFactory driverFactory = new DriverFactory();
	private TyreFactory tyreFactory = new TyreFactory();
	private List<Driver> drivers = new List<Driver>();

	public void SetTrackInfo(int lapsNumber, int trackLength)
	{
		this.lapsNumber = lapsNumber;
		this.trackLength = trackLength;
	}

	public void RegisterDriver(List<string> commandArgs)
	{
		try
		{
			Driver driver = driverFactory.CreateDriver(commandArgs);
			drivers.Add(driver);
		}
		catch (Exception)
		{
		}
	}

	public void DriverBoxes(List<string> commandArgs)
	{
		string reasonToBox = commandArgs[0];
		string driverName = commandArgs[1];

		Driver driver = drivers.FirstOrDefault(d => d.Name == driverName);

		switch (reasonToBox)
		{
			case "ChangeTyres":
				List<string> tyreArgs = commandArgs.Skip(2).ToList();
				Tyre tyre = tyreFactory.CreateTyre(tyreArgs);
				driver.Car.ChangeTyre(tyre);
				break;
			case "Refuel":
				double fuelAmount = double.Parse(commandArgs[2]);
				driver.Car.Refuel(fuelAmount);
				break;
		}
	}

	//public string CompleteLaps(List<string> commandArgs)
	//{
	//	//TODO: Add some logic here …
	//}

	//public string GetLeaderboard()
	//{
	//	//TODO: Add some logic here …
	//}

	public void ChangeWeather(List<string> commandArgs)
	{
		this.weather = commandArgs[0];
	}
}