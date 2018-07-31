using System.Text;

public class Seat : ICar
{
    public string Model { get; private set; }
    public string Color { get; private set; }

    public Seat(string model, string color)
    {
        Model = model;
        Color = color;
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();

        builder.AppendLine($"{Color} {GetType().Name} {Model}")
            .AppendLine(Start())
            .AppendLine(Stop());

        string result = builder.ToString().TrimEnd();
        return result;
    }
}