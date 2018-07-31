using System;

class PointInRectangle
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(Console.ReadLine());
        int pointsCount = int.Parse(Console.ReadLine());

        for (int counter = 0; counter < pointsCount; counter++)
        {
            Point point = new Point(Console.ReadLine());
            Console.WriteLine(rectangle.IsPointInRectangle(point));
        }
    }
}