using System;

class DrawingTool
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();

        switch (type)
        {
            case "Square":
                int side = int.Parse(Console.ReadLine());
                Square square = new Square(side);
                square.Draw();
                break;
            case "Rectangle":
                int width = int.Parse(Console.ReadLine());
                int heigth = int.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle(width, heigth);
                rectangle.Draw();
                break;
        }
    }
}