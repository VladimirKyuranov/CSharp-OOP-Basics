using System;

class StartUp
{
    static void Main(string[] args)
    {
        int peopleCount = int.Parse(Console.ReadLine());
        Team team = new Team("The Crows");
        for (int counter = 0; counter < peopleCount; counter++)
        {
            string[] personInfo = Console.ReadLine().Split();
            string firstName = personInfo[0];
            string lastName = personInfo[1];
            int age = int.Parse(personInfo[2]);
            decimal salary = decimal.Parse(personInfo[3]);

            try
            {
                Person person = new Person(firstName, lastName, age, salary);
                team.AddPlayer(person);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }

        Console.WriteLine($"First team has {team.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players");
    }
}