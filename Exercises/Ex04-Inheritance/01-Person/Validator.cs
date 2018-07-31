using System;
using System.Collections.Generic;
using System.Text;

public class Validator
{
    public static void Name(string name)
    {
        if (name?.Trim().Length < 3)
        {
            throw new ArgumentException("Name's length should not be less than 3 symbols!");
        }
    }

    public static void PersonAge(int age)
    {
        if (age < 0)
        {
            throw new ArgumentException("Age must be positive!");
        }
    }

    public static void ChildAge(int age)
    {
        if (age > 15)
        {
            throw new ArgumentException("Child's age must be less than 15!");
        }
    }
}