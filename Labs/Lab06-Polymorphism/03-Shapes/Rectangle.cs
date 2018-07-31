public class Rectangle : Shape
{
	double height;
	double width;

	public Rectangle(double height, double width)
	{
		this.height = height;
		this.width = width;
	}

	public override double CalculateArea()
	{
		double area = this.height * this.width;
		return area;
	}

	public override double CalculatePerimeter()
	{
		double perimeter = 2 * (this.height + this.width);
		return perimeter;
	}

	public override string Draw()
	{
		return base.Draw() + "Rectangle";
	}

}