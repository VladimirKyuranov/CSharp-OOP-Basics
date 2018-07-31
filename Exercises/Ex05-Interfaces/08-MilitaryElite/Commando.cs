using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Commando : SpecialisedSoldier, ICommando
{
    private ICollection<IMission> missions;

    public Commando(int id, string firstName, string lastName, decimal salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        this.missions = new List<IMission>();
    }

    public IReadOnlyCollection<IMission> Missions { get; set; }

    public void AddMission(IMission mission)
    {
        this.missions.Add(mission);
    }

    public void CompleteMission(IMission mission)
    {
        mission = this.Missions.FirstOrDefault(m => m.CodeName == mission.CodeName);
        mission.Complete();
    }

    public override string ToString()
    {
        string missions = $"  {string.Join(Environment.NewLine + "  ", this.missions)}";
        StringBuilder builder = new StringBuilder();
        builder.AppendLine(base.ToString())
			.AppendLine("Missions:")
            .AppendLine(missions);

        string result = builder.ToString().TrimEnd();
        return result;
    }
}