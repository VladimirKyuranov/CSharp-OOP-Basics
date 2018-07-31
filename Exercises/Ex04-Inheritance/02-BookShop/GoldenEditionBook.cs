using System;

public class GoldenEditionBook : Book
{
    public override decimal Price
    {
        get { return base.Price; }
        set { base.Price = value * 1.3m; }
    }

    public GoldenEditionBook(string author, string title, Decimal price)
        : base(author, title, price)
    {
    }
}