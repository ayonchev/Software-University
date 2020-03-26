using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WaterMonument : Monument
{
    public int FireAffinity { get; private set; }
    public WaterMonument(string name, int fireAffinity) : base(name)
    {
        this.FireAffinity = fireAffinity;
    }
}

