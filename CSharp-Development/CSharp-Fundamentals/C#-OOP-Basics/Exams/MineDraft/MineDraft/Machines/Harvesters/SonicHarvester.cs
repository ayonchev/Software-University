using System;
using System.Collections.Generic;
using System.Text;

public class SonicHarvester : Harvester
{
    public override string Type => "Sonic";
    public int SonicFactor { get; private set; }
    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) : base(id, oreOutput, energyRequirement)
    {
        this.SonicFactor = sonicFactor;
        base.EnergyRequirement /= SonicFactor;
    }
}
