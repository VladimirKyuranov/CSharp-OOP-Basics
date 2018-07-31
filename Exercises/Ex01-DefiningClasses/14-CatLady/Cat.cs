using System;
using System.Collections.Generic;
using System.Text;

public class Cat
{
    private string breed;
    private string name;
    private int earSize;
    private double furLength;
    private int decibels;

    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int EarSize
    {
        get { return earSize; }
        set { earSize = value; }
    }

    public double FurLength
    {
        get { return furLength; }
        set { furLength = value; }
    }

    public int Decibels
    {
        get { return decibels; }
        set { decibels = value; }
    }

    public Cat(string breed, string name, string parameter)
    {
        this.breed = breed;
        this.name = name;
        switch (breed)
        {
            case "Siamese":
                earSize = int.Parse(parameter);
                break;
            case "Cymric":
                furLength = double.Parse(parameter);
                break;
            case "StreetExtraordinaire":
                decibels = int.Parse(parameter);
                break;
        }
    }

    public override string ToString()
    {
        string parameter = string.Empty;

        switch (breed)
        {
            case "Siamese":
                parameter = $"{earSize}";
                break;
            case "Cymric":
                parameter = $"{furLength:F2}";
                break;
            case "StreetExtraordinaire":
                parameter = $"{decibels}";
                break;
        }

        return $"{breed} {name} {parameter}";
    }
}