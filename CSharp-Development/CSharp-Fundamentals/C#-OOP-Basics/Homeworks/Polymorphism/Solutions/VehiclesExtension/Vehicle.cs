using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicle : IVehicle
{
    private double fuelQuantity;
    public Vehicle(double currentFuelQuantity, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        this.FuelQuantity = currentFuelQuantity;
    }

    public double FuelQuantity
    {
        get { return this.fuelQuantity; }
        protected set
        {
            if (value > TankCapacity)
            {
                fuelQuantity = 0;
            }
            else
            {
                fuelQuantity = value;
            }
        }
    }

    public double TankCapacity { get; protected set; }

    public virtual double FuelConsumption { get; protected set; }
    public virtual void Drive(double distance, double changeInConsumption = 0)
    {
        double fuelForCurrentDistance = distance * (FuelConsumption + changeInConsumption);

        if (fuelForCurrentDistance <= FuelQuantity)
        {
            this.FuelQuantity -= fuelForCurrentDistance;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
        else
        {
            throw new ArgumentException($"{this.GetType().Name} needs refueling");
        }
    }

    public virtual void Refuel(double liters)
    {
        if (liters <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        else if (liters + FuelQuantity > TankCapacity)
        {
            throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
        }
        else
        {
            this.FuelQuantity += liters;
        }
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }
}
