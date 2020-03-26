using System;
using System.Collections.Generic;
using System.Text;

public abstract class Driver
{
    public string Name { get; private set; }
    public double TotalTime { get; set; }

    public Car Car { get; private set; }
    public double FuelConsumptionPerKm { get; private set; }
    public virtual double Speed { get; protected set; }

    protected Driver(string name, Car car, double fuelConsumptionPerKm)
    {
        this.Name = name;
        this.Car = car;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        this.Speed = (Car.Hp + Car.Tyre.Degradation) / Car.FuelAmount;
    }

    public virtual void ReduceFuelAmount(int length)
    {
        this.Car.ReduceFuel(length, this.FuelConsumptionPerKm);
    }

    public override string ToString()
    {
        return $"{Name} wins the race for {TotalTime} seconds.";
    }
}
