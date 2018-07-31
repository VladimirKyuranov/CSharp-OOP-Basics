using System;

public class TankOverflowException :Exception
{
	private double quantity;

	public TankOverflowException(double quantity)
	{
		this.quantity = quantity;
	}

	public override string Message => $"Cannot fit {quantity} fuel in the tank";
}