using System;
using System.Collections.Generic;
using System.Text;

public abstract class Harvester : Machine
{
    private const double MaxEnergyRequirement = 20_000;

    private double oreOutput;
    private double energyRequirement;

    public double OreOutput
    {
        get { return oreOutput; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
            }
            oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get { return energyRequirement; }
        protected set
        {
            if (value < 0 || value > MaxEnergyRequirement)
            {
                throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            }
            energyRequirement = value;
        }
    }


    protected Harvester(string id, double oreOutput, double energyRequirement) : base(id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public override string ToString()
    {
        return $"{this.Type} Harvester - {this.Id}" + Environment.NewLine +
                      $"Ore Output: {this.OreOutput}" + Environment.NewLine +
                      $"Energy Requirement: {this.EnergyRequirement}";
    }
}

