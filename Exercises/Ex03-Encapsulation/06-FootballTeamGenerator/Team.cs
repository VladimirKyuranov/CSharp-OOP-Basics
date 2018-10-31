using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private string name;
    private Dictionary<string, Player> players;
    private double rating = 0;

    public string Name
    {
        get { return this.name; }
        private set
        {
            Validator.Name(value);
            this.name = value;
        }
    }

    public Team(string name)
    {
        this.Name = name;
        this.players = new Dictionary<string, Player>();
    }

    public void AddPlayer(Player player)
    {
        this.players.Add(player.Name, player);
    }

    public void RemovePlayer(string playerName)
    {
        if (this.players.ContainsKey(playerName) == false)
        {
            throw new ArgumentException($"Player {playerName} is not in {this.name} team.");
        }

        this.players.Remove(playerName);
    }

    public void SetRating()
    {
        if (this.players.Count > 0)
        {
            this.rating = Math.Round(players.Values.Average(p => p.SkillLevel));
        }
    }

    public override string ToString()
    {
        return $"{this.name} - {this.rating}";
    }
}