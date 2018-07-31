using System;
using System.Collections.Generic;
using System.Linq;

class FootballTeamGenerator
{
    static void Main(string[] args)
    {
        var teams = new Dictionary<string, Team>();

        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            string[] commandArgs = input
                .Split(';', StringSplitOptions.RemoveEmptyEntries);
            string command = commandArgs[0];
            string teamName = commandArgs[1];
            try
            {
                switch (command)
                {
                    case "Team":
                        Team team = new Team(teamName);
                        teams.Add(teamName, team);
                        break;
                    case "Add":
                        Validation.TeamExists(teamName, teams);
                        string playerName = commandArgs[2];
                        List<int> stats = commandArgs
                            .Skip(3)
                            .Select(int.Parse)
                            .ToList();
                        Player player = new Player(playerName, stats);
                        teams[teamName].AddPlayer(player);
                        break;
                    case "Remove":
                        Validation.TeamExists(teamName, teams);
                        playerName = commandArgs[2];
                        teams[teamName].RemovePlayer(playerName);
                        break;
                    case "Rating":
                        Validation.TeamExists(teamName, teams);
                        teams[teamName].SetRating();
                        Console.WriteLine(teams[teamName]);
                        break;
                }
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }
    }
}