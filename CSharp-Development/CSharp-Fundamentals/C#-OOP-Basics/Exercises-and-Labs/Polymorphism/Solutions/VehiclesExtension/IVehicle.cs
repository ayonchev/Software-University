using System;
using System.Collections.Generic;
using System.Text;

interface IVehicle
{
    double FuelQuantity { get; }
    double FuelConsumption { get; }
    double TankCapacity { get; }
    void Drive(double distance, double changeInConsumption);
    void Refuel(double liters);
}
