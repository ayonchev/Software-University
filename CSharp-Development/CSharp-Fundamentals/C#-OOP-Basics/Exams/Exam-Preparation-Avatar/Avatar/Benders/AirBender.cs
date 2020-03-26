using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AirBender : Bender
{
    private double аerialIntegrity;
    public AirBender(string name, int power, double aerialIntegrity) : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public override double GetPower()
    {
        return this.AerialIntegrity * Power;
    }
}

