using System.Text;

public class Student : Human
{
    private string facultyNumber;

    public string FacultyNumber
    {
        get { return facultyNumber; }
        set
        {
            Validator.FacultyNumber(value);
            facultyNumber = value;
        }
    }

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        FacultyNumber = facultyNumber;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine(base.ToString());
        builder.AppendLine($"Faculty number: {facultyNumber}");
        string result = builder.ToString().TrimEnd();
        return result;
    }
}