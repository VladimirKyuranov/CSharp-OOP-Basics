using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
	static void Main(string[] args)
	{
		var army = new Dictionary<int, ISoldier>();
		string input;

		try
		{
			while ((input = Console.ReadLine()) != "End")
			{
				string[] soldierArgs = input.Split();
				string soldierType = soldierArgs[0];
				int id = int.Parse(soldierArgs[1]);
				string firstName = soldierArgs[2];
				string lastName = soldierArgs[3];
				decimal salary = decimal.Parse(soldierArgs[4]);

				switch (soldierType)
				{
					case "Private":
						Private @private = new Private(id, firstName, lastName, salary);
						army.Add(id, @private);
						break;
					case "LeutenantGeneral":
						LeutenantGeneral leutenantGeneral = new LeutenantGeneral(id, firstName, lastName, salary);
						int[] soldiers = soldierArgs.Skip(5).Select(int.Parse).ToArray();
						foreach (var soldier in soldiers)
						{
							leutenantGeneral.AddSoldier(army[soldier]);
						}
						army.Add(id, leutenantGeneral);
						break;
					case "Engineer":
						string engineerCorps = soldierArgs[5];
						Engineer engineer = new Engineer(id, firstName, lastName, salary, engineerCorps);
						string[] repairs = soldierArgs.Skip(6).ToArray();

						for (int index = 0; index < repairs.Length; index++)
						{
							string partName = repairs[index];
							int hoursWorked = int.Parse(repairs[++index]);
							Repair repair = new Repair(partName, hoursWorked);
							engineer.AddRepair(repair);
						}

						army.Add(id, engineer);
						break;
					case "Commando":
						string commandoCorps = soldierArgs[5];
						Commando commando = new Commando(id, firstName, lastName, salary, commandoCorps);
						string[] missions = soldierArgs.Skip(6).ToArray();

						for (int index = 0; index < missions.Length; index++)
						{
							try
							{
								string missionName = missions[index];
								string state = missions[++index];
								Mission mission = new Mission(missionName, state);
								commando.AddMission(mission);
							}
							catch (ArgumentException)
							{
								continue;
							}
						}

						army.Add(id, commando);
						break;
					case "Spy":
						int codeNumber = int.Parse(soldierArgs[4]);
						Spy spy = new Spy(id, firstName, lastName, codeNumber);
						army.Add(id, spy);
						break;
					default:
						throw new ArgumentException("Invalid soldier type!");
				}
			}

		}
		catch (Exception)
		{

		}

		foreach (var soldier in army.Values)
		{
			Console.WriteLine(soldier);
		}
	}
}