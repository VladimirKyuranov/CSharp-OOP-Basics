using System;

public class Validator
{
    public static void AuthorName(string authorName)
    {
        string[] names = authorName.Split();

        if (names.Length == 2 && Char.IsDigit(names[1][0]))
        {
            throw new ArgumentException("Author not valid!");
        }
    }

    public static void Title(string title)
    {
        if (title?.Trim().Length < 3)
        {
            throw new ArgumentException("Title not valid!");
        }
    }

    public static void Price(decimal price)
    {
        if (price <= 0)
        {
            throw new ArgumentException("Price not valid!");
        }
    }
}
