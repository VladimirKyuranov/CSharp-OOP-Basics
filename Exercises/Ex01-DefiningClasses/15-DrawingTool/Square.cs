using System;
using System.Collections.Generic;
using System.Text;

public class Square
{
    public int Side { get; set; }

    public Square(int side)
    {
        Side = side;
    }

    public void Draw()
    {
        Console.Write("|");
        Console.Write(new string('-', Side));
        Console.WriteLine("|");

        for (int row = 0; row < Side - 2; row++)
        {
            Console.Write("|");
            Console.Write(new string(' ', Side));
            Console.WriteLine("|");
        }

        Console.Write("|");
        Console.Write(new string('-', Side));
        Console.WriteLine("|");
    }
}
