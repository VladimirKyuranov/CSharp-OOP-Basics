using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        List<IBirthable> inhabitants = new List<IBirthable>();
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] inhabitantInfo = input.Split();

            switch (inhabitantInfo[0])
            {
                case "Citizen":
                    string name = inhabitantInfo[1];
                    int age = int.Parse(inhabitantInfo[2]);
                    string id = inhabitantInfo[3];
                    string birthdate = inhabitantInfo[4];
                    IBirthable citizen = new Citizen(name, age, id, birthdate);
                    inhabitants.Add(citizen);
                    break;
                case "Pet":
                    name = inhabitantInfo[1];
                    birthdate = inhabitantInfo[2];
                    IBirthable pet = new Pet(name, birthdate);
                    inhabitants.Add(pet);
                    break;
            }
        }

        string year = Console.ReadLine();

        inhabitants
            .Where(i => Validator.CorrectYear(i, year))
            .ToList()
            .ForEach(i => Console.WriteLine(i.Birthdate));
    }
}