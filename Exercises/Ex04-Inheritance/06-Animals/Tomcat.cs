﻿public class Tomcat : Cat, ISoundProducable
{
    public Tomcat(string name, int age)
        : base(name, age, "Male") { }

    public override string ProduceSound()
    {
        return "MEOW";
    }
}
