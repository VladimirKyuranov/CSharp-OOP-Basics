using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle
{
    public int Width { get; set; }
    public int Heigth { get; set; }

    public Rectangle(int width, int heigth)
    {
        Width = width;
        Heigth = heigth;
    }

    public void Draw()
    {
        Console.Write("|");
        Console.Write(new string('-', Width));
        Console.WriteLine("|");

        for (int row = 0; row < Heigth - 2; row++)
        {
            Console.Write("|");
            Console.Write(new string(' ', Width));
            Console.WriteLine("|");
        }

        Console.Write("|");
        Console.Write(new string('-', Width));
        Console.WriteLine("|");
    }
}