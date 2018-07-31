public abstract class Tyre
{
	private const double MinDegradation = 0;

	private double degradation;

	protected Tyre(string name, double hardness)
	{
		this.Name = name;
		this.Hardness = hardness;
		this.Degradation = 100;
	}

	public string Name { get; }

	public double Hardness { get; }

	public virtual double Degradation
	{
		get { return degradation; }
		protected set
		{
			Validator.CheckTyre(value, MinDegradation);
			this.degradation = value;
		}
	}

	public virtual void CompleteLap()
	{
		this.Degradation -= this.Hardness;
	}
}