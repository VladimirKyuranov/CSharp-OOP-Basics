using System;

public class NegativeFuelException : Exception
{
	public override string Message => "Fuel must be a positive number";	
}