using System.Collections.Generic;
using System.Linq;

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
        get { return this.name; }
        private set
        {
            Validator.Name(value);
            this.name = value;
        }
    }

    public int Endurance
    {
        get { return this.endurance; }
        private set
        {
            Validator.Stat("Endurance", value);
            this.endurance = value;
        }
    }

    public int Sprint
    {
        get { return this.sprint; }
        private set
        {
            Validator.Stat("Sprint", value);
            this.sprint = value;
        }
    }

    public int Dribble
    {
        get { return this.dribble; }
        private set
        {
            Validator.Stat("Dribble", value);
            this.dribble = value;
        }
    }

    public int Passing
    {
        get { return this.passing; }
        private set
        {
            Validator.Stat("Passing", value);
            this.passing = value;
        }
    }

    public int Shooting
    {
        get { return this.shooting; }
        set
        {
            Validator.Stat("Shooting", value);
            this.shooting = value;
        }
    }

    public Player(string name, List<int> stats)
    {
        this.Name = name;
        this.Endurance = stats[0];
        this.Sprint = stats[1];
        this.Dribble = stats[2];
        this.Passing = stats[3];
        this.Shooting = stats[4];
        this.SkillLevel = stats.Average();
    }
}