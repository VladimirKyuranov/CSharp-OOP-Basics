using System.Text;

public class Cat : Animal
{
	public Cat(string name, string favouriteFood)
		: base(name, favouriteFood)
	{
	}

	public override string ExplainSelf()
	{
		StringBuilder builder = new StringBuilder();
		builder.AppendLine(base.ExplainSelf())
			.AppendLine("MEEOW");
		string result = builder.ToString().TrimEnd();
		return result;
	}
}