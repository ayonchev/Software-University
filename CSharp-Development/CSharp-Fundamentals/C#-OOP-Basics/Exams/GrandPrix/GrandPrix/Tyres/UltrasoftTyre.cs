using System;
using System.Collections.Generic;
using System.Text;

public class UltrasoftTyre : Tyre
{
    private double degradation;

    public override double Degradation
    {
        get { return degradation; }
        protected set
        {
            if (value < 30)
            {
                throw new ArgumentException("Blown Tyre");
            }
            degradation = value;
        }
    }
    public override string Name => "Ultrasoft";
    public double Grip { get; set; }
    public UltrasoftTyre(double hardness, double grip) : base(hardness)
    {
        this.Grip = grip;
    }

    public override void ReduceDegradation()
    {
        this.Degradation -= (Hardness + Grip);
    }
}

