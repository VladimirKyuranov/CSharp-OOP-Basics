using System;
using System.Collections.Generic;

class CatLady
{
    static void Main(string[] args)
    {
        var cats = new Dictionary<string, Cat>();
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] catInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string breed = catInfo[0];
            string name = catInfo[1];
            string parameter = catInfo[2];
            Cat cat = new Cat(breed, name, parameter);
            cats.Add(name, cat);
        }

        string catName = Console.ReadLine();

        Console.WriteLine(cats[catName]);
    }
}