using System;

class Dates
{
    static void Main(string[] args)
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();

        DateModifier dateModifier = new DateModifier();
        int dayDifference = dateModifier.GetDaysBetweenDates(firstDate, secondDate);

        Console.WriteLine(dayDifference);
    }
}