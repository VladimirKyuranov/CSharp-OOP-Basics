public class Dough
{
    const double MIN_WEIGHT = 1;
    const double MAX_WEIGHT = 200;

    private string flourType;
    private string bakingTechnique;
    private double weight;
    private double totalCalories;

    public string FlourType
    {
        get { return flourType; }
        set
        {
            Validation.FlourType(value);
            flourType = value;
        }
    }

    public string BakingTechnique
    {
        get { return bakingTechnique; }
        set
        {
            Validation.BakingTechnique(value);
            bakingTechnique = value;
        }
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            Validation.Weight(value, MIN_WEIGHT, MAX_WEIGHT, "Dough");
            weight = value;
        }
    }



    public Dough(string flourType, string bakingTechnique, double weight)
    {
        FlourType = flourType;
        BakingTechnique = bakingTechnique;
        Weight = weight;
    }

    public double TotalCalories()
    {
        totalCalories = 2 * weight;

        if (flourType.ToLower() == "white")
        {
            totalCalories *= 1.5;
        }

        switch (bakingTechnique.ToLower())
        {
            case "crispy":
                totalCalories *= 0.9;
                break;
            case "chewy":
                totalCalories *= 1.1;
                break;
        }

        return totalCalories;
    }
}