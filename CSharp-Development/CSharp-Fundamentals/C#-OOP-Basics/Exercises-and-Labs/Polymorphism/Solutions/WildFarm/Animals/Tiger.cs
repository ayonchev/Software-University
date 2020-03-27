using System;
using System.Collections.Generic;
using System.Text;

public class Tiger : Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
        base.Foods = new List<string>()
        {
            nameof(Meat)
        };
        base.GainWeight = 1;
    }

    public override void AskForFood()
    {
        Console.WriteLine("ROAR!!!");
    }
}
