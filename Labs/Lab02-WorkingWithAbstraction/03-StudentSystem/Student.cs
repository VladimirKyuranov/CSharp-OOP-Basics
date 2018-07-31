using System;
using System.Collections.Generic;
using System.Text;

public class Student
{
    private string name;
    private int age;
    private double grade;

    public double Grade
    {
        get { return grade; }
        set { grade = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Student(string name, int age, double grade)
    {
        this.Name = name;
        this.Age = age;
        this.grade = grade;
    }

    public override string ToString()
    {
        string gradeCommentary = "Very nice person.";

        if (grade >= 5)
        {
            gradeCommentary = "Excellent student.";
        }
        else if (grade >= 3.5)
        {
            gradeCommentary = "Average student.";
        }

        return $"{name} is {age} years old. {gradeCommentary}";
    }
}