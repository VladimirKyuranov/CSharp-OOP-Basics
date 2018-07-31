using System;
using System.Text.RegularExpressions;

public class Validator
{
    public static void NameStartLetter(string name, string field)
    {
        if (Char.IsUpper(name[0]) == false)
        {
            throw new ArgumentException($"Expected upper case letter! Argument: {field}");
        }
    }

    public static void NameLength(string name, int minLength, string field)
    {
        if (name?.Trim().Length < minLength)
        {
            throw new ArgumentException($"Expected length at least {minLength} symbols! Argument: {field}");
        }
    }

    public static void FacultyNumber(string facultyNumber)
    {
        Regex pattern = new Regex(@"^[A-Za-z\d]{5,10}$");

        if (pattern.IsMatch(facultyNumber) == false)
        {
            throw new ArgumentException("Invalid faculty number!");
        }
    }

    public static void WeekSalary(decimal salary, decimal minSalary)
    {
        if (salary <= minSalary)
        {
            throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
        }
    }

    public static void WorkHours(decimal hours, int minHours, int maxHours)
    {
        if (hours < minHours || hours > maxHours)
        {
            throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
        }
    }
}