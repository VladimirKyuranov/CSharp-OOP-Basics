public class BusOutOfFuelException : OutOfFuelException
{
	public override string Message => "Bus" + base.Message;
}