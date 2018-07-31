public class TruckOutOfFuelException : OutOfFuelException
{
	public override string Message => "Truck" + base.Message;
}