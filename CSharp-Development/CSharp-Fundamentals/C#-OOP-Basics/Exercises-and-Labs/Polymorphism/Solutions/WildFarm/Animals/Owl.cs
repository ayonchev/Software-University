using System;
using System.Collections.Generic;
using System.Text;

public class Owl : Bird
{
    public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
        base.Foods = new List<string>()
        {
            nameof(Meat)
        };
        base.GainWeight = 0.25;
    }

    public override void AskForFood()
    {
        Console.WriteLine("Hoot Hoot");
    }
}
