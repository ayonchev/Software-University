using System;
using System.Collections.Generic;
using System.Text;

public class Tomcat : Cat
{
    public Tomcat(string name, int age)
        : base(name, age)
    {
        base.Gender = "Male";
    }

    public override string ProduceSound()
    {
        return "MEOW";
    }
}
