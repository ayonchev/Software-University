using System;
using System.Collections.Generic;

public class SpeedRacing
{
    static void Main()
    {
        int countOfCars = int.Parse(Console.ReadLine());
        Dictionary<string, Car> cars = new Dictionary<string, Car>();

        for (int i = 0; i < countOfCars; i++)
        {
            string[] currentCar = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string model = currentCar[0];
            decimal fuelAmount = decimal.Parse(currentCar[1]);
            decimal fuelConsumption = decimal.Parse(currentCar[2]);

            if (!cars.ContainsKey(model))
            {
                var car = new Car()
                {
                    FuelAmount = fuelAmount,
                    FuelConsumption = fuelConsumption
                };
                cars.Add(model, car);
            }
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] driveCommand = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string model = driveCommand[1];
            decimal amountOfKm = decimal.Parse(driveCommand[2]);

            if (cars.ContainsKey(model))
            {
                cars[model].Drive(amountOfKm);
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Key} {car.Value.FuelAmount:F2} {car.Value.DistanceTravelled}");
        }
    }
}
