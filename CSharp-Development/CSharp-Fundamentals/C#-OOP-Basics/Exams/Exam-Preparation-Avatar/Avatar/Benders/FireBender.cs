using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FireBender : Bender
{
    public double HeatAggression { get; private set; }
    public FireBender(string name, int power, double heatAggression) : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    public override double GetPower()
    {
        return HeatAggression * Power;
    }
}
