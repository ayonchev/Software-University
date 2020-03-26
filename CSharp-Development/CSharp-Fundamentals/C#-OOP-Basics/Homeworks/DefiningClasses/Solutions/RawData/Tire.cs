using System;
using System.Collections.Generic;
using System.Text;

public class Tire
{
    private double tirePressure;
    private int tireAge;

    public double TirePressure
    {
        get { return this.tirePressure; }
        set { this.tirePressure = value; }
    }
    public int TireAge
    {
        get { return this.tireAge; }
        set { this.tireAge = value; }
    }

    public Tire(double currenTirePressure, int currentTireAge)
    {
        this.tireAge = currentTireAge;
        this.tirePressure = currenTirePressure;
    }
}
