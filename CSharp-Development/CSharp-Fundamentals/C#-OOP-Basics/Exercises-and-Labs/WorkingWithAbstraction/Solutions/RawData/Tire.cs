using System;
using System.Collections.Generic;
using System.Text;
public class Tire
{
    public int TireAge { get; set; }
    public double TirePressure { get; set; }

    public Tire(int currenTireAge, double currenTirePressure)
    {
        TireAge = currenTireAge;
        TirePressure = currenTirePressure;
    }
}
