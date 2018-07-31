using System;
using System.Collections.Generic;

class ShoppingSpree
{
    static void Main(string[] args)
    {
        string[] peopleInfo = Console.ReadLine()
            .Split("=;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        string[] productsInfo = Console.ReadLine()
            .Split("=;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        var people = new Dictionary<string, Person>();
        var products = new Dictionary<string, Product>();

        try
        {
            for (int index = 0; index < peopleInfo.Length; index += 2)
            {
                string name = peopleInfo[index];
                decimal money = decimal.Parse(peopleInfo[index + 1]);
                Person person = new Person(name, money);
                people.Add(name, person);
            }

            for (int index = 0; index < productsInfo.Length; index += 2)
            {
                string name = productsInfo[index];
                decimal cost = decimal.Parse(productsInfo[index + 1]);
                Product product = new Product(name, cost);
                products.Add(name, product);
            }
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
            Environment.Exit(0);
        }
        string order;

        while ((order = Console.ReadLine()) != "END")
        {
            string[] orderInfo = order.Split();
            string personName = orderInfo[0];
            string productname = orderInfo[1];

            people[personName].BuyProduct(products[productname]);
        }

        foreach (var person in people)
        {
            Console.WriteLine(person.Value);
        }
    }
}