public class CarOutOfFuelException : OutOfFuelException
{
	public override string Message => "Car" + base.Message;
}