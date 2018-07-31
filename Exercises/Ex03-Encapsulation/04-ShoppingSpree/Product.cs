public class Product
{
    private string name;
    private decimal cost;

    public string Name
    {
        get { return name; }
        set
        {
            Validation.EmptyName(value);
            name = value;
        }
    }

    public decimal Cost
    {
        get { return cost; }
        set
        {
            Validation.NegativeMoney(value);
            cost = value;
        }
    }

    public Product(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }

    public override string ToString()
    {
        return name;
    }
}