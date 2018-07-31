public class Rebel : INameable
{
    public string Name { get; private set; }

    public int Age { get; private set; }

    public string Group { get; private set; }

    public Rebel(string name, int age, string group)
    {
        Name = name;
        Age = age;
        Group = group;
    }
}