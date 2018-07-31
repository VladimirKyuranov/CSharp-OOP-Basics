using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Team
{
    private string name;
    private Dictionary<string, Player> players;
    private double rating = 0;

    public string Name
    {
        get { return name; }
        private set
        {
            Validation.Name(value);
            name = value;
        }
    }

    public Team(string name)
    {
        Name = name;
        players = new Dictionary<string, Player>();
    }

    public void AddPlayer(Player player)
    {
        players.Add(player.Name, player);
    }

    public void RemovePlayer(string playerName)
    {
        if (players.ContainsKey(playerName) == false)
        {
            throw new ArgumentException($"Player {playerName} is not in {name} team.");
        }

        players.Remove(playerName);
    }

    public void SetRating()
    {
        if (players.Count > 0)
        {
            rating = Math.Round(players.Values.Average(p => p.SkillLevel));
        }
    }

    public override string ToString()
    {
        return $"{name} - {rating}";
    }
}