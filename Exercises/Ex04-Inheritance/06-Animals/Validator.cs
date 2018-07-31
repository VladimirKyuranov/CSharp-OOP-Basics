using System;

public class Validator
{
    public static void Blank(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Invalid input!");
        }
    }

    public static void NegativeAge(int age)
    {
        if (age < 0)
        {
            throw new ArgumentException("Invalid input!");
        }
    }

    public static void Age(string age)
    {
        try
        {
            int.Parse(age);
        }
        catch (Exception)
        {
            throw new ArgumentException("Invalid input!");
        }
    }
}