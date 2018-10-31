using System;
using System.Collections.Generic;

public class Validator
{
    public static void Name(string name)
    {
        if (name?.Trim().Length == 0)
        {
            throw new ArgumentException("A name should not be empty");
        }
    }

    public static void Stat(string statName, int statValue)
    {
        if (statValue < 0 || statValue > 100)
        {
            throw new ArgumentException($"{statName} should be between 0 and 100.");
        }
    }

    public static void TeamExists(string name, Dictionary<string, Team> teams)
    {
        if (teams.ContainsKey(name) == false)
        {
            throw new ArgumentException($"Team {name} does not exist.");
        }
    }
}