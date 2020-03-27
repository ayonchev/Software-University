using System;
using System.Collections.Generic;
using System.Text;

public class Hen : Bird
{
    public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
        base.GainWeight = 0.35;
    }

    public override void AskForFood()
    {
        Console.WriteLine("Cluck");
    }
}
