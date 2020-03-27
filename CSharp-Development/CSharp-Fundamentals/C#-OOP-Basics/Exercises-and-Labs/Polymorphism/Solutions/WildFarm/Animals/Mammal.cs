using System;
using System.Collections.Generic;
using System.Text;

public abstract class Mammal : Animal
{
    public Mammal(string name, double weight, string livingRegion)
        : base(name, weight)
    {
        this.LivingRegion = livingRegion;
    }

    protected string LivingRegion { get; set; }

    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.EatenFood}]";
    }
}
