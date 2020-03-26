using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private const double  fuelTankMaxCapacity = 160;
    private double fuelAmount;
    public double FuelAmount
    {
        get { return this.fuelAmount; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Out of fuel");
            }
            else if (value > fuelTankMaxCapacity)
            {
                this.fuelAmount = fuelTankMaxCapacity;
            }
            else
            {
                this.fuelAmount = value;
            }
        }
    }
    public int Hp { get; private set; }

    public Tyre Tyre { get; private set; }

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.Hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }

    public void Refuel(List<string> commandArgs)
    {
        double fuelAmount = double.Parse(commandArgs[0]);
        this.FuelAmount += fuelAmount;
    }

    public void ReduceFuel(int length, double fuelConsumption)
    {
        this.FuelAmount -= (length * fuelConsumption);
    }

    public void ChangeTyres(List<string> commandArgs)
    {
        this.Tyre = TyreFactory.CreateTyre(commandArgs);
    }
}

