using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        Dictionary<string, INameable> inhabitants = new Dictionary<string, INameable>();
        int count = int.Parse(Console.ReadLine());

        for(int counter = 0; counter < count; counter++)
        {
            string[] inhabitantInfo = Console.ReadLine().Split();

            switch (inhabitantInfo.Length)
            {
                case 4:
                    string name = inhabitantInfo[0];
                    int age = int.Parse(inhabitantInfo[1]);
                    string id = inhabitantInfo[2];
                    string birthdate = inhabitantInfo[3];
                    INameable citizen = new Citizen(name, age, id, birthdate);
                    inhabitants.Add(name, citizen);
                    break;
                case 3:
                    name = inhabitantInfo[0];
                    age = int.Parse(inhabitantInfo[1]);
                    string group = inhabitantInfo[2];
                    INameable rebel = new Rebel(name, age, group);
                    inhabitants.Add(name, rebel);
                    break;
            }
        }

        int foodBougth = 0;
        string personName;

        while ((personName = Console.ReadLine()) != "End")
        {
            if (inhabitants.ContainsKey(personName) == false)
            {
                continue;
            }

            INameable person = inhabitants[personName];

            switch (person.GetType().Name)
            {
                case "Citizen":
                    foodBougth += 10;
                    break;
                case "Rebel":
                    foodBougth += 5;
                    break;
            }
        }

        Console.WriteLine(foodBougth);
    }
}