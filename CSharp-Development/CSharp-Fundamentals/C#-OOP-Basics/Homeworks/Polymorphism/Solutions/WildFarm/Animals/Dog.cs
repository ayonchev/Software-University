using System;
using System.Collections.Generic;
using System.Text;

public class Dog : Mammal
{
    public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
        base.Foods = new List<string>()
        {
            nameof(Meat)
        };
        base.GainWeight = 0.4;
    }

    public override void AskForFood()
    {
        Console.WriteLine("Woof!");
    }
}
