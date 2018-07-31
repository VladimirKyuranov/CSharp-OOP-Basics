using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Player
{
    private string name;
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;

    public double SkillLevel { get; private set; }

    public string Name
    {
        get { return name; }
        private set
        {
            Validation.Name(value);
            name = value;
        }
    }

    public int Endurance
    {
        get { return endurance; }
        private set
        {
            Validation.Stat("Endurance", value);
            endurance = value;
        }
    }

    public int Sprint
    {
        get { return sprint; }
        private set
        {
            Validation.Stat("Sprint", value);
            sprint = value;
        }
    }

    public int Dribble
    {
        get { return dribble; }
        private set
        {
            Validation.Stat("Dribble", value);
            dribble = value;
        }
    }

    public int Passing
    {
        get { return passing; }
        private set
        {
            Validation.Stat("Passing", value);
            passing = value;
        }
    }

    public int Shooting
    {
        get { return shooting; }
        set
        {
            Validation.Stat("Shooting", value);
            shooting = value;
        }
    }

    public Player(string name, List<int> stats)
    {
        Name = name;
        Endurance = stats[0];
        Sprint = stats[1];
        Dribble = stats[2];
        Passing = stats[3];
        Shooting = stats[4];
        SkillLevel = stats.Average();
    }
}