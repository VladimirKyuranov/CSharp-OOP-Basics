public class UltrasoftTyre : Tyre
{
	private const double MinDegradation = 30;

	public UltrasoftTyre(double hardness, double grip)
		: base("Ultrasoft", hardness)
	{
		this.Grip = grip;
	}

	public double Grip { get; }

	public override double Degradation
	{
		get => base.Degradation;
		protected set
		{
			Validator.CheckTyre(value, MinDegradation);
			base.Degradation = value;
		}
	}

	public override void CompleteLap()
	{
		base.CompleteLap();
		this.Degradation -= this.Grip;
	}
}