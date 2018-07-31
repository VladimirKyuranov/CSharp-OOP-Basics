    using System;
    using System.Collections.Generic;

public class StudentSystem
{
    private Dictionary<string, Student> repo;

    public StudentSystem()
    {
        this.Repo = new Dictionary<string, Student>();
    }

    public Dictionary<string, Student> Repo
    {
        get { return repo; }
        private set { repo = value; }
    }

    public void ParseCommand(string command)
    {
        string[] args = command.Split();

        switch (args[0])
        {
            case "Create":
                var name = args[1];
                var age = int.Parse(args[2]);
                var grade = double.Parse(args[3]);

                if (repo.ContainsKey(name) == false)
                {
                    var student = new Student(name, age, grade);
                    Repo[name] = student;
                }

                break;
            case "Show":
                name = args[1];

                if (Repo.ContainsKey(name))
                {
                    Console.WriteLine(Repo[name]);
                }

                break;
        }
    }
}