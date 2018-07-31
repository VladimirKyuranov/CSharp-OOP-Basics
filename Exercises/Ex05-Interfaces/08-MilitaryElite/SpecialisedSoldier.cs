using System;
using System.Text;

public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps)
        : base(id, firstName, lastName, salary)
    {
        ParseCorpes(corps);
    }

    public CorpsEnum Corps { get; private set; }

    private void ParseCorpes(string corps)
    {
        bool validCorps = Enum.TryParse(typeof(CorpsEnum), corps, out object outCorps);

        if (validCorps == false)
        {
            throw new ArgumentException("Invalid corps!");
        }

        this.Corps = (CorpsEnum)outCorps;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine(base.ToString())
            .AppendLine($"Corps: {this.Corps}");

        string result = builder.ToString().TrimEnd();
        return result;
    }
}