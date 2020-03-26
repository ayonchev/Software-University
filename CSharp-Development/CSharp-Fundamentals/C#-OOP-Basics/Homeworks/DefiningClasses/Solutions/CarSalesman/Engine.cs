using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    private string model;
    private double power;
    private double displacement;
    private string efficiency;

    public string Model
    {
        get { return this.model; }
        set { this.model = value;  }
    }

    public double Power
    {
        get { return this.power; }
        set { this.power = value; }
    }

    public double Displacement
    {
        get { return this.displacement; }
        set { this.displacement = value; }
    }

    public string Efficiency
    {
        get { return this.efficiency; }
        set { this.efficiency = value; }
    }

    public Engine(string model, double power)
    {
        this.model = model;
        this.power = power;
        this.displacement = -1;
        this.efficiency = "n/a";
    }

    public Engine(string model, double power, double displacement) : this(model, power)
    {
        this.displacement = displacement;
    }

    public Engine(string model, double power, string efficiency) : this(model, power)
    {
        this.efficiency = efficiency;
    }

    public Engine(string model, double power, double displacement, string efficiency) : this(model, power, displacement)
    {
        this.efficiency = efficiency;
    }
}
