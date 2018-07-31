using System;
using System.Collections.Generic;
using System.Linq;

class People
{
    static void Main(string[] args)
    {
        int peopleCount = int.Parse(Console.ReadLine());
        var people = new List<Person>();

        for (int counter = 0; counter < peopleCount; counter++)
        {
            string[] personInfo = Console.ReadLine().Split();
            string firstName = personInfo[0];
            string lastName = personInfo[1];
            int age = int.Parse(personInfo[2]);
            Person person = new Person(firstName, lastName, age);
            people.Add(person);
        }

        people
            .OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p));
    }
}