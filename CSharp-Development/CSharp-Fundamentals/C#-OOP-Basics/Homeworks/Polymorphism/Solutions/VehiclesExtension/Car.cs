using System;
using System.Collections.Generic;
using System.Text;

public class Car : Vehicle
{
    public Car(double currentFuelQuantity, double currentFuelConsumption, double currentTankCapacity)
        : base(currentFuelQuantity, currentTankCapacity)
    {
        this.FuelConsumption = currentFuelConsumption;
    }

    public override double FuelConsumption
    {
        protected set { base.FuelConsumption = value + 0.9; }
    }
}

