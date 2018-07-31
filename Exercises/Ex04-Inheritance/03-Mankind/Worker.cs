using System.Text;

public class Worker : Human
{
    private const int WORK_DAYS = 5;
    private const decimal MIN_SALARY = 10;
    private const int MIN_HOURS = 1;
    private const int MAX_HOURS = 12;

    private decimal weekSalary;
    private decimal hoursPerDay;

    public decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            Validator.WeekSalary(value, MIN_SALARY);
            weekSalary = value;
        }
    }

    public decimal HoursPerDay
    {
        get { return hoursPerDay; }
        set
        {
            Validator.WorkHours(value, MIN_HOURS, MAX_HOURS);
            hoursPerDay = value;
        }
    }

    public Worker(string firstName, string lastName, decimal weekSalay, decimal hoursPerDay)
        : base(firstName, lastName)
    {
        WeekSalary = weekSalay;
        HoursPerDay = hoursPerDay;
    }

    private decimal GetHourSalary()
    {
        decimal hourSalary = weekSalary / (WORK_DAYS * hoursPerDay);

        return hourSalary;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine(base.ToString());
        builder.AppendLine($"Week Salary: {weekSalary:F2}");
        builder.AppendLine($"Hours per day: {hoursPerDay:F2}");
        builder.AppendLine($"Salary per hour: {GetHourSalary():F2}");
        string result = builder.ToString().TrimEnd();
        return result;
    }
}
