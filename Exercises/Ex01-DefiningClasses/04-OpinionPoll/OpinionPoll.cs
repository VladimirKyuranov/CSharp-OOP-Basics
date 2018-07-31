using System;

class OpinionPoll
{
    static void Main(string[] args)
    {
        int familySize = int.Parse(Console.ReadLine());
        Family family = new Family();

        for (int i = 0; i < familySize; i++)
        {
            string[] personInfo = Console.ReadLine().Split();
            Person familyMember = new Person
            {
                Name = personInfo[0],
                Age = int.Parse(personInfo[1])
            };
            family.AddMember(familyMember);
        }

        Console.WriteLine(string.Join(Environment.NewLine, family.GetOlderMembersSorted()));
    }
}