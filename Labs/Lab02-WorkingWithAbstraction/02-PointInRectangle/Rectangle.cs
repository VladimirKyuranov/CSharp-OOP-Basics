using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Rectangle
{
    public Point TopLeft { get; set; }
    public Point BottomRight { get; set; }

    public Rectangle(string input)
    {
        int[] coords = input
            .Split()
            .Select(int.Parse)
            .ToArray();

        TopLeft = new Point(coords[0], coords[1]);
        BottomRight = new Point(coords[2], coords[3]);
    }

    public bool IsPointInRectangle(Point point)
    {
        bool isXInside = TopLeft.X <= point.X && point.X <= BottomRight.X;
        bool isYInside = TopLeft.Y <= point.Y && point.Y <= BottomRight.Y;

        return isXInside && isYInside;
    }
}