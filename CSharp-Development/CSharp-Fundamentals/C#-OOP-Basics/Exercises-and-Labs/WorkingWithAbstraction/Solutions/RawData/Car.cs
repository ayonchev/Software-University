using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
    public List<Tire> Tires { get; }
    public Car(string model, Engine currentEngine,Cargo currentCargo, List<Tire> currentTires)
    {
        this.Model = model;
        this.Engine = currentEngine;
        this.Cargo = currentCargo;
        this.Tires = currentTires;
    }
}
