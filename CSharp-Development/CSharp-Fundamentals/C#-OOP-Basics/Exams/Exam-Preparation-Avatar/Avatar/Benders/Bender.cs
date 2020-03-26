using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Bender
{
    public string Name { get; private set; }
    public int Power  { get; private set; }

    protected Bender(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }

    public abstract double GetPower();
}

