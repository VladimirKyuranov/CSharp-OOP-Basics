using System;

class MordorsCruelPlan
{
    static void Main(string[] args)
    {
        string[] foods = Console.ReadLine()
            .Split();

        int happinessPoints = 0;
        string happinessLevel = string.Empty;

        foreach (var food in foods)
        {
            switch (food.ToLower())
            {
                case "cram":
                    happinessPoints += 2;
                    break;
                case "lembas":
                    happinessPoints += 3;
                    break;
                case "apple":
                case "melon":
                    happinessPoints++;
                    break;
                case "honeycake":
                    happinessPoints += 5;
                    break;
                case "mushrooms":
                    happinessPoints -= 10;
                    break;
                default:
                    happinessPoints--;
                    break;
            }
        }

        if (happinessPoints < -5)
        {
            happinessLevel = "Angry";
        }
        else if (happinessPoints <= 0)
        {
            happinessLevel = "Sad";
        }
        else if (happinessPoints <= 15)
        {
            happinessLevel = "Happy";
        }
        else
        {
            happinessLevel = "JavaScript";
        }

        Console.WriteLine(happinessPoints);
        Console.WriteLine(happinessLevel);
    }
}