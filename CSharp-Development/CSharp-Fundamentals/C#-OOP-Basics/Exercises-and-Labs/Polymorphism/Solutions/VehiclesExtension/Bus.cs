using System;
using System.Collections.Generic;
using System.Text;

public class Bus : Vehicle
{
    public Bus(double currentFuelQuantity, double currentFuelConsumption, double currentTankCapacity)
        : base(currentFuelQuantity, currentTankCapacity)
    {
        base.FuelConsumption = currentFuelConsumption;
    }
}

