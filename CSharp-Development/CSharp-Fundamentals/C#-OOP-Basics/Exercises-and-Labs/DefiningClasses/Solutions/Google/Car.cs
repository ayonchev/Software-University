using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private double speed;

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }
    public double Speed
    {
        get { return this.speed; }
        set { this.speed = value; }
    }

    public Car()
    {
        
    }
    public Car(string currentModel, double currentSpeed)
    {
        this.model = currentModel;
        this.speed = currentSpeed;
    }

    public override string ToString()
    {
        if (this.model == null)
        {
            return string.Empty;
        }
        return $"{this.model} {this.speed}\r\n";
    }
}
