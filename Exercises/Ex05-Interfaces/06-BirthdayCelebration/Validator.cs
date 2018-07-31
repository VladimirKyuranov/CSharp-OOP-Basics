public class Validator
{
    public static bool InvalidId(IIdentifiable inhabitant, string fragment)
    {
        return inhabitant.Id.EndsWith(fragment);
    }

    public static bool CorrectYear(IBirthable inhabitant, string year)
    {
        return inhabitant.Birthdate.EndsWith(year);
    }
}
