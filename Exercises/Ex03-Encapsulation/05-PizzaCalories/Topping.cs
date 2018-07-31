public class Topping
{
    const double MIN_WEIGHT = 1;
    const double MAX_WEIGHT = 50;
    private string type;
    private double weight;
    private double totalCalories;

    public string Type
    {
        get { return type; }
        set
        {
            Validation.ToppingType(value);
            type = value;
        }
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            Validation.Weight(value, MIN_WEIGHT, MAX_WEIGHT, type);
            weight = value;
        }
    }


    public Topping(string type, double weight)
    {
        Type = type;
        Weight = weight;
    }

    public double TotalCalories()
    {
        totalCalories = 2 * weight;

        switch (type.ToLower())
        {
            case "meat":
                totalCalories *= 1.2;
                break;
            case "veggies":
                totalCalories *= 0.8;
                break;
            case "cheese":
                totalCalories *= 1.1;
                break;
            case "sauce":
                totalCalories *= 0.9;
                break;
        }

        return totalCalories;
    }
}