using System;
using System.Collections.Generic;
using System.Text;

public class Ferrari : ICar
{
    public Ferrari(string driverName)
    {
        this.DriverName = driverName;
        this.Model = "488-Spider";
    }

    public string Model { get; set; }
    public string DriverName { get; set; }

    public string PushBrakes()
    {
        return "Brakes!";
    }

    public string PushGas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.PushBrakes()}/{this.PushGas()}/{this.DriverName}";
    }
}

