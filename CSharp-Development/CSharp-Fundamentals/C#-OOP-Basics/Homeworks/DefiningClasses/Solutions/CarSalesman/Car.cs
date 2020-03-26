using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private Engine engine;
    private double weight;
    private string color;

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public Engine Engine
    {
        get { return this.engine; }
        set { this.engine = value; }
    }

    public double Weight
    {
        get { return this.weight; }
        set { this.weight = value; }
    }

    public string Color
    {
        get { return this.color; }
        set { this.color = value; }
    }

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
        this.color = "n/a";
        this.weight = -1;
    }

    public Car(string model, Engine engine, double weight) : this(model, engine)
    {
        this.weight = weight;
    }

    public Car(string model, Engine engine, string color) : this(model, engine)
    {
        this.color = color;
    }

    public Car(string model, Engine engine, double weight, string color) : this(model, engine, weight)
    {
        this.color = color;
    }

    public override string ToString()
    {
        string currentDisplacement = this.engine.Displacement.ToString();
        string currentWeight = this.weight.ToString();
        if (this.engine.Displacement == -1)
        {
            currentDisplacement = "n/a";
        }
        if (this.weight == -1)
        {
            currentWeight = "n/a";
        }
        string result =
            $"{this.model}:\r\n  " +
            $"{this.engine.Model}:\r\n    " +
            $"Power: {this.engine.Power}\r\n    " +
            $"Displacement: {currentDisplacement}\r\n    " +
            $"Efficiency: {this.engine.Efficiency}\r\n  " +
            $"Weight: {currentWeight}\r\n  " +
            $"Color: {this.color}";

        return result;
    }
}
