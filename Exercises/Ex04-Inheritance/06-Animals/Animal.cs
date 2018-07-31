using System.Text;

public class Animal : ISoundProducable
{
    protected string name;
    protected int age;
    protected string gender;

    public string Name
    {
        get { return name; }
        set
        {
            Validator.Blank(value);
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            Validator.NegativeAge(value);
            age = value;
        }
    }

    public string Gender
    {
        get { return gender; }
        set
        {
            Validator.Blank(value);
            gender = value;
        }
    }

    public Animal()
    {

    }

    public Animal(string name, int age, string gender)
    {
        this.name = name;
        Age = age;
        this.gender = gender;
    }

    public virtual string ProduceSound()
    {
        return string.Empty;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine(GetType().Name)
               .AppendLine($"{name} {age} {gender}")
               .AppendLine(ProduceSound());
        string result = builder.ToString().TrimEnd();
        return result;
    }
}