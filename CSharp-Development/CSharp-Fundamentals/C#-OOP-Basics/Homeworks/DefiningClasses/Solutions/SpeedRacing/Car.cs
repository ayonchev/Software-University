using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private decimal fuelAmount;
    private decimal fuelConsumption;
    private decimal distanceTravelled;

    public decimal FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }
    public decimal FuelConsumption
    {
        get { return this.fuelConsumption; }
        set { this.fuelConsumption = value; }
    }
    public decimal DistanceTravelled
    {
        get { return this.distanceTravelled; }
        set { this.distanceTravelled = value; }
    }

    public void Drive(decimal amountOfKm)
    {
        if (amountOfKm * this.fuelConsumption > this.fuelAmount)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            this.distanceTravelled += amountOfKm;
            this.fuelAmount -= amountOfKm * this.fuelConsumption;
        }
    }
}
