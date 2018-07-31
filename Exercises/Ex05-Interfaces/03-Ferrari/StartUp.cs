using System;

class StartUp
{
    static void Main(string[] args)
    {
        string driver = Console.ReadLine();
        ICar ferrari = new Ferrari(driver);
        Console.WriteLine(ferrari);
    }
}