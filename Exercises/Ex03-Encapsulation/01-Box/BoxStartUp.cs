﻿using System;

class BoxStartUp
{
    static void Main(string[] args)
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double heigth = double.Parse(Console.ReadLine());

        Box box = new Box(length, width, heigth);

        Console.WriteLine($"Surface Area - {box.SurfaceArea():F2}");
        Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():F2}");
        Console.WriteLine($"Volume - {box.Volume():F2}");
    }
}