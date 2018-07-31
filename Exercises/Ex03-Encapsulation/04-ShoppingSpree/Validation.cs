using System;

public class Validation
{
    public static void EmptyName(string name)
    {
        if (name?.Trim().Length == 0)
        {
            throw new ArgumentException("Name cannot be empty");
        }
    }

    public static void NegativeMoney(decimal money)
    {
        if (money < 0)
        {
            throw new ArgumentException("Money cannot be negative");
        }
    }
}
