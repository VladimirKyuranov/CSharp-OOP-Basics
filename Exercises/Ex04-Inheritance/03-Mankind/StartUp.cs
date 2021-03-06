﻿using System;

class StartUp
{
    static void Main(string[] args)
    {
        string[] studentInfo = Console.ReadLine().Split();
        string[] workerInfo = Console.ReadLine().Split();

        try
        {
            Student student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
            Worker worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]), decimal.Parse(workerInfo[3]));

            Console.WriteLine(student);
            Console.WriteLine();
            Console.WriteLine(worker);
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
    }
}