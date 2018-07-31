using System;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        string input;

        while ((input = Console.ReadLine()) != "Beast!")
        {
            try
            {
                string type = input;
                string[] animalInfo = Console.ReadLine().Split();
                string name = animalInfo[0];
                Validator.Age(animalInfo[1]);
                int age = int.Parse(animalInfo[1]);
                string gender = string.Empty;
                Animal animal = new Animal();

                if (animalInfo.Length == 3)
                {
                    gender = animalInfo[2];
                }

                switch (type)
                {
                    case "Cat":
                        animal = new Cat(name, age, gender);
                        break;
                    case "Dog":
                        animal = new Dog(name, age, gender);
                        break;
                    case "Frog":
                        animal = new Frog(name, age, gender);
                        break;
                    case "Kitten":
                        animal = new Kitten(name, age);
                        break;
                    case "Tomcat":
                        animal = new Tomcat(name, age);
                        break;
                    default:
                        throw new ArgumentException("Invalid input!");
                }

                animals.Add(animal);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }
}