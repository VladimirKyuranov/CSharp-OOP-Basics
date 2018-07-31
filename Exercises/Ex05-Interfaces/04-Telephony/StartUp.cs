using System;

class StartUp
{
    static void Main(string[] args)
    {
        string[] phoneNumbers = Console.ReadLine().Split();
        string[] websites = Console.ReadLine().Split();
        Smartphone smartphone = new Smartphone();

        smartphone.Call(phoneNumbers);
        smartphone.Browse(websites);
    }
}