public class Kitten : Cat, ISoundProducable
{
    public Kitten(string name, int age) 
        : base(name, age, "Female") { }

    public override string ProduceSound()
    {
        return "Meow";
    }
}
