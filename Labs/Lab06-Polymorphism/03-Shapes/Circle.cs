using System;

public class Circle : Shape
{
	double radius;

	public Circle(double radius)
	{
		this.radius = radius;
	}

	public override double CalculateArea()
	{
		double area = Math.PI * this.radius * this.radius;
		return area;
	}

	public override double CalculatePerimeter()
	{
		double perimeter = 2 * Math.PI * this.radius;
		return perimeter;
	}

	public override string Draw()
	{
		return base.Draw() + "Circle";
	}
}