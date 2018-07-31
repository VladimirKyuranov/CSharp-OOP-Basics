public class Person
{
    protected string name;
    protected int age;

    public string Name
    {
        get { return name; }
        set
        {
            Validator.Name(value);
            name = value;
        }
    }

    public virtual int Age
    {
        get { return age; }
        set
        {
            Validator.PersonAge(value);
            age = value;
        }
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name: {name}, Age: {age}";
    }
}