public class Validator
{
    public static bool InvalidId(IIdentifiable inhabitant, string fragment)
    {
        return inhabitant.Id.EndsWith(fragment);
    }
}
