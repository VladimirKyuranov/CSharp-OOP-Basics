using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        List<IIdentifiable> inhabitants = new List<IIdentifiable>();
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] inhabitantInfo = input.Split();

            switch (inhabitantInfo.Length)
            {
                case 2:
                    string model = inhabitantInfo[0];
                    string id = inhabitantInfo[1];
                    IIdentifiable robot = new Robot(model, id);
                    inhabitants.Add(robot);
                    break;
                case 3:
                    string name = inhabitantInfo[0];
                    int age = int.Parse(inhabitantInfo[1]);
                    id = inhabitantInfo[2];
                    IIdentifiable citizen = new Citizen(name, age, id);
                    inhabitants.Add(citizen);
                    break;
            }
        }

        string fragment = Console.ReadLine();

        inhabitants
            .Where(i => Validator.InvalidId(i, fragment))
            .ToList()
            .ForEach(i => Console.WriteLine(i.Id));
    }
}