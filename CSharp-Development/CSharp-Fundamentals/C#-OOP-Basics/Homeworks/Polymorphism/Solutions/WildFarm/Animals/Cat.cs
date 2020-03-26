using System;
using System.Collections.Generic;
using System.Text;

public class Cat : Feline
{
    public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
        base.Foods = new List<string>()
        {
            nameof(Meat), nameof(Vegetable)
        };
        base.GainWeight = 0.3;
    }

    public override void AskForFood()
    {
        Console.WriteLine("Meow");
    }
}

