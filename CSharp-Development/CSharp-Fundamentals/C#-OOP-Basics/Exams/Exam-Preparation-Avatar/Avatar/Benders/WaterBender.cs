using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WaterBender : Bender
{
    public double WaterClarity { get; private set; }
    public WaterBender(string name, int power, double waterClarity) : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }

    public override double GetPower()
    {
        return WaterClarity * Power;
    }
}

