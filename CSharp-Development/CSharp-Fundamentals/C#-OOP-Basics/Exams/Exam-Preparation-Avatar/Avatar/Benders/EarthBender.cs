using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EarthBender : Bender
{
    public double GroundSaturation { get; private set; }
    public EarthBender(string name, int power, double groundSaturation) : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    public override double GetPower()
    {
        return this.GroundSaturation * Power;
    }
}

