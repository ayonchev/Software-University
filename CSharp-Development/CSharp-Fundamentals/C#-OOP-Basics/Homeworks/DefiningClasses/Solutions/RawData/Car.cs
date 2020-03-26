using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private List<Tire> tires;
    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public Engine Engine
    {
        get { return this.engine; }
        set { this.engine = value; }
    }

    public Cargo Cargo
    {
        get { return this.cargo; }
        set { this.cargo = value; }
    }

    public List<Tire> Tires
    {
        get { return this.tires; }
        set { this.tires = value; }
    }

    public Car(
        string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType,
        double firstTirePressure, int firstTireAge, double secondTirePressure, int secondTireAge,
        double thirdTirePressure, int thirdTireAge, double fourthTirePressure, int fourthTireAge)
    {
        this.model = model;
        this.engine = new Engine(engineSpeed, enginePower);
        this.cargo = new Cargo(cargoWeight, cargoType);
        this.Tires = new List<Tire>()
        {
            new Tire(firstTirePressure, firstTireAge),
            new Tire(secondTirePressure, secondTireAge),
            new Tire(thirdTirePressure, thirdTireAge),
            new Tire(fourthTirePressure, fourthTireAge)
        };
    }
}
