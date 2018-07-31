using System;

class RhombusOfStars
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int spaces = size - 1;
        int stars = 1;

        for (int row = 1; row < 2 * size; row++)
        {
            PrintRow(spaces, stars);

            if (row < size)
            {
                spaces--;
                stars++;
            }
            else
            {
                spaces++;
                stars--;
            }
        }
    }

    private static void PrintRow(int spaces, int stars)
    {
        Console.Write(new string(' ', spaces));

        for (int col = 1; col < stars; col++)
        {
            Console.Write("* ");
        }

        Console.WriteLine("*");
    }
}