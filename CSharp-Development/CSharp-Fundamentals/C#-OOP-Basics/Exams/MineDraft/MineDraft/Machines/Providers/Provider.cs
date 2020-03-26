using System;
using System.Collections.Generic;
using System.Text;

public abstract class Provider : Machine
{
    private const double MaxEnergyOutput = 10_000;

    private double energyOutput;

    public double EnergyOutput
    {
        get { return energyOutput; }
        protected set
        {
            if (value > MaxEnergyOutput)
            {
                throw new ArgumentException($"Provider is not registered, because of it's EnergyOutput");
            }
            energyOutput = value;
        }
    }

    protected Provider(string id, double energyOutput) : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public override string ToString()
    {
        return $"{this.Type} Provider - {this.Id}" + Environment.NewLine +
               $"Energy Output: {this.EnergyOutput}";
    }
}