using System;
using System.Collections.Generic;
using System.Text;

class Box
{
    private double length;
    private double width;
    private double heigth;

    public Box(double length, double width, double heigth)
    {
        this.length = length;
        this.width = width;
        this.heigth = heigth;
    }

    public double LateralSurfaceArea()
    {
        return 2 * heigth * (length + width);
    }

    public double SurfaceArea()
    {
        return LateralSurfaceArea() + 2 * length * width;
    }

    public double Volume()
    {
        return length * width * heigth;
    }
}