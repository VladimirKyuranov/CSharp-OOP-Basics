using System;
using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
	private ICollection<IRepair> repairs;

	public Engineer(int id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
	{
		this.repairs = new List<IRepair>();
	}

	public IReadOnlyCollection<Repair> Repairs { get; private set; }

	public void AddRepair(IRepair repair)
	{
		this.repairs.Add(repair);
	}

	public override string ToString()
	{
		string repairs = $"  {string.Join(Environment.NewLine + "  ", this.repairs)}";
		StringBuilder builder = new StringBuilder();
		builder.AppendLine(base.ToString())
			.AppendLine("Repairs:")
			.AppendLine(repairs);

		string result = builder.ToString().TrimEnd();
		return result;
	}
}