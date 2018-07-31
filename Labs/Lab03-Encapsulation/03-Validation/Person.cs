using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    const int MIN_LENGTH = 3;
    const decimal MIN_SALARY = 460;
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public string FirstName
    {
        get { return firstName; }
        set
        {
            Validation(value, "First name");
            firstName = value;
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            Validation(value, "Last name");
            lastName = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }

            age = value;
        }
    }

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < MIN_SALARY)
            {
                throw new ArgumentException($"Salary cannot be less than {MIN_SALARY} leva!");
            }
            salary = value;
        }
    }

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
    }

    public void IncreaseSalary(decimal bonus)
    {
        bonus *= salary / 100;

        if (age < 30)
        {
            salary += bonus / 2;
        }
        else
        {
            salary += bonus;
        }
    }

    private void Validation(string field, string fieldName)
    {
        if (field?.Length < MIN_LENGTH)
        {
            throw new ArgumentException($"{fieldName} cannot contain fewer than {MIN_LENGTH} symbols!");
        }
    }

    public override string ToString()
    {
        return $"{firstName} {lastName} receives {salary:F2} leva.";
    }
}