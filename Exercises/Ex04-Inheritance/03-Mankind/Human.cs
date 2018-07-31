using System.Text;

public class Human
{
    private const int FIRST_NAME_MIN_LENGTH = 4;
    private const int LAST_NAME_MIN_LENGTH = 3;

    protected string firstName;
    protected string lastName;

    public string FirstName
    {
        get { return firstName; }
        set
        {
            Validator.NameStartLetter(value, "firstName");
            Validator.NameLength(value, FIRST_NAME_MIN_LENGTH, "firstName");
            firstName = value;
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            Validator.NameStartLetter(value, "lastName");
            Validator.NameLength(value, LAST_NAME_MIN_LENGTH, "lastName");
            lastName = value;
        }
    }

    public Human(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"First Name: {firstName}");
        builder.AppendLine($"Last Name: {lastName}");
        string result = builder.ToString().TrimEnd();
        return result;
    }
}