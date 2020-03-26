using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class DriverFactory
{
    public static Driver CreateDriver(List<string> commandArgs)
    {
        string type = commandArgs[0];
        string name = commandArgs[1];
        int hp = int.Parse(commandArgs[2]);
        double fuelAmount = double.Parse(commandArgs[3]);
        Tyre tyre = TyreFactory.CreateTyre(commandArgs.Skip(4).ToList());
        Car car = new Car(hp, fuelAmount, tyre);

        if (tyre != null)
        {
            switch (type)
            {
                case "Aggressive":
                    return new AggressiveDriver(name, car);
                case "Endurance":
                    return new EnduranceDriver(name, car);
            }
        }

        return null;
    }
}
