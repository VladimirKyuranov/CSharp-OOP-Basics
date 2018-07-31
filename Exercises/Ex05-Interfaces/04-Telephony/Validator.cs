using System;
using System.Linq;

public class Validator
{
    public static bool PhoneNumber(string phoneNumber)
    {
        return phoneNumber.Any(p => char.IsDigit(p) == false);
    }

    public static bool Website(string website)
    {
        return website.Any(p => char.IsDigit(p));
    }
}