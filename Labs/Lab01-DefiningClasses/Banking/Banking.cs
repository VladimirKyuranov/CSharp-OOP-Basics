using System;
using System.Collections.Generic;

class Banking
{
    static void Main(string[] args)
    {
        var accounts = new Dictionary<int, BankAccount>();

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] commandArgs = input.Split();
            string command = commandArgs[0];
            int id = int.Parse(commandArgs[1]);

            switch (command)
            {
                case "Create":
                    if (accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Account already exists");
                    }
                    else
                    {
                        accounts.Add(id, new BankAccount { Id = id });
                    }
                    break;
                case "Deposit":
                    if (AccountExists(id, accounts))
                    {
                        int amount = int.Parse(commandArgs[2]);
                        accounts[id].Deposit(amount);
                    }
                    break;
                case "Withdraw":
                    if (AccountExists(id, accounts))
                    {
                        int amount = int.Parse(commandArgs[2]);
                        accounts[id].Withdraw(amount);
                    }
                    break;
                case "Print":
                    if (AccountExists(id, accounts))
                    {
                        Console.WriteLine(accounts[id]);
                    }
                    break;
            }
        }
    }

    static bool AccountExists(int id, Dictionary<int, BankAccount> accounts)
    {
        if (accounts.ContainsKey(id) == false)
        {
            Console.WriteLine("Account does not exist");
            return false;
        }

        return true;
    }
}