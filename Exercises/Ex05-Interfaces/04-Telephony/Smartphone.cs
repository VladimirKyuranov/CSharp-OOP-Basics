using System;

public class Smartphone : ICallable, IBrowsable
{
    public void Call(string[] phoneNumbers)
    {
        foreach (var phoneNumber in phoneNumbers)
        {
            if (Validator.PhoneNumber(phoneNumber))
            {
                Console.WriteLine("Invalid number!");
                continue;
            }

            Console.WriteLine($"Calling... {phoneNumber}");
        }
    }

    public void Browse(string[] websites)
    {
        foreach (var website in websites)
        {
            if (Validator.Website(website))
            {
                Console.WriteLine("Invalid URL!");
                continue;
            }

            Console.WriteLine($"Browsing: {website}!");
        }
    }
}