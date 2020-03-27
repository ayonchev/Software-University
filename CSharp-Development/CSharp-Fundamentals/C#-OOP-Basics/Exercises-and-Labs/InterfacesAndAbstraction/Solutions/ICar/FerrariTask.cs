using System;

class FerrariTask
{
    static void Main()
    {
        string driverName = Console.ReadLine();
        ICar currentCar = new Ferrari(driverName);
        Console.WriteLine(currentCar);
    }
}

