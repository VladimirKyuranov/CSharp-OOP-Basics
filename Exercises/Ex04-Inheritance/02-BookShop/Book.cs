using System;

public class Book
{
    protected string title;
    protected string author;
    protected decimal price;

    public string Title
    {
        get { return title; }
        set
        {
            Validator.Title(value);
            title = value;
        }
    }

    public string Author
    {
        get { return author; }
        set
        {
            Validator.AuthorName(value);
            author = value;
        }
    }


    public virtual decimal Price
    {
        get { return price; }
        set
        {
            Validator.Price(value);
            price = value;
        }
    }

    public Book(string author, string title, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public override string ToString()
    {
        string line = Environment.NewLine;
        return $"Type: {GetType().Name}" +
            $"{line}Title: {title}" +
            $"{line}Author: {author}" +
            $"{line}Price: {price:F2}";
    }
}
