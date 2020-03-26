using System;
using System.Collections.Generic;
using System.Text;

public class Cat : Animal
{
    protected Cat(string name, int age)
        : base(name, age)
    {

    }
    public Cat(string name, int age, string gender)
        : base(name, age, gender)
    {

    }

    public override string ProduceSound()
    {
        return "Meow meow";
    }
}
