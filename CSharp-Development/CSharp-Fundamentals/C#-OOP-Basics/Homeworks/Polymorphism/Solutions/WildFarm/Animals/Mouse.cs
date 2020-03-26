using System;
using System.Collections.Generic;
using System.Text;

public class Mouse : Mammal
{
    public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
        base.Foods = new List<string>()
        {
            nameof(Vegetable), nameof(Fruit)
        };
        base.GainWeight = 0.10;
    }

    public override void AskForFood()
    {
        Console.WriteLine("Squeak");
    }
}
