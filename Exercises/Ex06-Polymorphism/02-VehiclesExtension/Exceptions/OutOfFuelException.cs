using System;

public class OutOfFuelException : Exception
{
	public override string Message => $" needs refueling";
}