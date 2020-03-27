using System;
using System.Collections.Generic;

public class VehiclesExtension
{
    static void Main()
    {
        Dictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>();

        string[] carData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] truckData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] busData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Car newCar = new Car(double.Parse(carData[1]), double.Parse(carData[2]), double.Parse(carData[3]));
        Truck newTruck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]), double.Parse(truckData[3]));
        Bus newBus = new Bus(double.Parse(busData[1]), double.Parse(busData[2]), double.Parse(busData[3]));

        vehicles.Add(nameof(Car), newCar);
        vehicles.Add(nameof(Truck), newTruck);
        vehicles.Add(nameof(Bus), newBus);

        int numberOfCommands = int.Parse(Console.ReadLine());

        ExecuteCommand(numberOfCommands, vehicles);

        PrintVehicles(vehicles);
    }

    private static void PrintVehicles(Dictionary<string, Vehicle> vehicles)
    {
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.Value);
        }
    }

    private static void ExecuteCommand(int numberOfCommands, Dictionary<string, Vehicle> vehicles)
    {
        for (int commandIndex = 0; commandIndex < numberOfCommands; commandIndex++)
        {
            try
            {
                string[] currentCommand = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string commandType = currentCommand[0];
                string vehicle = currentCommand[1];
                double distanceOrFuel = double.Parse(currentCommand[2]);

                if (commandType == "Drive")
                {
                    if (vehicle == "Bus")
                    {
                        vehicles[vehicle].Drive(distanceOrFuel, 1.4);
                    }
                    else
                    {
                        vehicles[vehicle].Drive(distanceOrFuel);
                    }
                }
                else if (commandType == "DriveEmpty")
                {
                    vehicles[vehicle].Drive(distanceOrFuel);
                }
                else if (commandType == "Refuel")
                {
                    vehicles[vehicle].Refuel(distanceOrFuel);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

