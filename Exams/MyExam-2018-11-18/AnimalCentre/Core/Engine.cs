using AnimalCentre.Models.Contracts;
using System;
using System.Linq;

namespace AnimalCentre.Core
{
    public class Engine
    {
        private AnimalCentre ac = new AnimalCentre();

        public void Run()
        {
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] commandArgs = input.Split();

                    string command = commandArgs[0];
                    string name;
                    int procedureTime;

                    switch (command)
                    {
                        case "RegisterAnimal":
                            string type = commandArgs[1];
                            name = commandArgs[2];
                            int energy = int.Parse(commandArgs[3]);
                            int happiness = int.Parse(commandArgs[4]);
                            procedureTime = int.Parse(commandArgs[5]);
                            Console.WriteLine(ac.RegisterAnimal(type, name, energy, happiness, procedureTime));
                            break;
                        case "Chip":
                            name = commandArgs[1];
                            procedureTime = int.Parse(commandArgs[2]);
                            Console.WriteLine(ac.Chip(name, procedureTime));
                            break;
                        case "Vaccinate":
                            name = commandArgs[1];
                            procedureTime = int.Parse(commandArgs[2]);
                            Console.WriteLine(ac.Vaccinate(name, procedureTime));
                            break;
                        case "Fitness":
                            name = commandArgs[1];
                            procedureTime = int.Parse(commandArgs[2]);
                            Console.WriteLine(ac.Fitness(name, procedureTime));
                            break;
                        case "Play":
                            name = commandArgs[1];
                            procedureTime = int.Parse(commandArgs[2]);
                            Console.WriteLine(ac.Play(name, procedureTime));
                            break;
                        case "DentalCare":
                            name = commandArgs[1];
                            procedureTime = int.Parse(commandArgs[2]);
                            Console.WriteLine(ac.DentalCare(name, procedureTime));
                            break;
                        case "NailTrim":
                            name = commandArgs[1];
                            procedureTime = int.Parse(commandArgs[2]);
                            Console.WriteLine(ac.NailTrim(name, procedureTime));
                            break;
                        case "Adopt":
                            name = commandArgs[1];
                            string owner = commandArgs[2];
                            IAnimal animal = ac.GetAnimal(name);
                            Console.WriteLine(ac.Adopt(name, owner));

                            
                            break;
                        case "History":
                            string procedureType = commandArgs[1];
                            Console.WriteLine(ac.History(procedureType));
                            break;
                        default:
                            break;
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine($"InvalidOperationException: {ioe.Message}");
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine($"ArgumentException: {ae.Message}");
                }
            }

            foreach (var owner in ac.AddoptedPets.OrderBy(o => o.Key))
            {
                Console.WriteLine($"--Owner: {owner.Key}");
                Console.WriteLine($"   - Adopted animals: {string.Join(" ", owner.Value.Select(a => a.Name))}");
            }
        }
    }
}
