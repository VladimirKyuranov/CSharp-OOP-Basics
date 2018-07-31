using System;

public static class Validator
{
	public static void CheckTyre(double degradation, double minDegradation)
	{
		if (degradation < minDegradation)
		{
			throw new ArgumentException(ErrorMessages.BlownTyre);
		}
	}

	public static void CheckFuel(double fuelAmount)
	{
		if (fuelAmount < 0)
		{
			throw new ArgumentException(ErrorMessages.OutOfFuel);
		}
	}
}