using System;
using System.Collections.Generic;
using System.Text;

public class AggressiveDriver : Driver
{
    private const double fuelConsumptionPerKm = 2.7;
    public AggressiveDriver(string name, Car car) : base(name, car, fuelConsumptionPerKm)
    {
        base.Speed *= 1.3;
    }
}

