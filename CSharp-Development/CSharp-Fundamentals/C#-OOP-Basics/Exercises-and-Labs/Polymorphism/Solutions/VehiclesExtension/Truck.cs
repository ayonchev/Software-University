using System;
using System.Collections.Generic;
using System.Text;

public class Truck : Vehicle
{
    public Truck(double currentFuelQuantity, double currentFuelConsumption, double currentTankCapacity)
        : base(currentFuelQuantity, currentTankCapacity)
    {
        this.FuelConsumption = currentFuelConsumption;
    }

    public override double FuelConsumption
    {
        protected set { base.FuelConsumption = 1.6 + value; }
    }

    public override void Refuel(double liters)
    {
        if (base.FuelQuantity + liters > base.TankCapacity)
        {
            throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
        }
        liters *= 0.95;
        base.Refuel(liters);
    }
}

