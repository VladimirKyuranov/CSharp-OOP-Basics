using System;
using System.Collections.Generic;
using System.Text;

public class LieutenantGeneral : Private, ILieutenantGeneral
{
    private ICollection<ISoldier> privates;

    public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
        : base(id, firstName, lastName, salary)
    {
        this.privates = new List<ISoldier>();
    }

    public IReadOnlyCollection<ISoldier> Privates => (IReadOnlyCollection<Soldier>)privates;

    public void AddSoldier(ISoldier soldier)
    {
        this.privates.Add(soldier);
    }

    public override string ToString()
    {
        string privates = $"  {string.Join(Environment.NewLine + "  ", this.privates)}";
        StringBuilder builder = new StringBuilder();
        builder.AppendLine(base.ToString())
            .AppendLine("Privates:")
            .AppendLine(privates);

        string result = builder.ToString().TrimEnd();
        return result;
    }
}