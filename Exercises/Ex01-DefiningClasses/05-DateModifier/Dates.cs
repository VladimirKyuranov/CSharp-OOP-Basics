using System;

namespace DefiningClasses
{
    public class Dates
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            StartUp dateModifier = new StartUp();
            int dayDifference = dateModifier.GetDaysBetweenDates(firstDate, secondDate);

            Console.WriteLine(dayDifference);
        }
    }
}