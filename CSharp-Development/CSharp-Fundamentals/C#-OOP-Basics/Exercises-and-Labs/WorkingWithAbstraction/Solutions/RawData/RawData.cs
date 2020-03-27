using System;
using System.Collections.Generic;
using System.Linq;

public class RawData
{
    static void Main(string[] args)
    {
        int numberOfCars = int.Parse(Console.ReadLine());
        List<Car> cars = AddCars(numberOfCars);

        string filter = Console.ReadLine();
        PrintFilteredCars(filter, cars);
    }

    static void PrintFilteredCars(string filter, List<Car> cars)
    {
        if (filter == "fragile")
        {
            List<string> fragile = cars
                .Where(x => x.Cargo.CargoType == "fragile" && x.Tires.Any(y => y.TirePressure < 1))
                .Select(x => x.Model)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, fragile));
        }
        else
        {
            List<string> flamable = cars
                .Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250)
                .Select(x => x.Model)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, flamable));
        }
    }

    static List<Car> AddCars(int numberOfCars)
    {
        List<Car> cars = new List<Car>();
        for (int i = 0; i < numberOfCars; i++)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = parameters[0];
            Engine currentEngine = new Engine(int.Parse(parameters[1]), int.Parse(parameters[2]));
            Cargo currentCargo = new Cargo(int.Parse(parameters[3]), parameters[4]);
            List<Tire> currentTires = new List<Tire>()
            {
                new Tire(int.Parse(parameters[6]), double.Parse(parameters[5])), 
                new Tire(int.Parse(parameters[8]), double.Parse(parameters[7])),
                new Tire(int.Parse(parameters[10]), double.Parse(parameters[9])),
                new Tire(int.Parse(parameters[12]), double.Parse(parameters[11]))
            };
            Car currentCar = new Car(model, currentEngine, currentCargo, currentTires);
            cars.Add(currentCar);
        }
        return cars;
    }
}
