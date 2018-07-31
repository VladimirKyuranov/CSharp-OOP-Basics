public class Child : Person
{
    public override int Age
    {
        get { return base.Age; }
        set
        {
            Validator.ChildAge(value);
            base.Age = value;
        }
    }

    public Child(string name, int age)
        : base(name, age)
    {
    }
}