using System;
using System.Collections.Generic;
using System.Linq;

public class CarSalesman
{
    static void Main()
    {
        int countOfEngines = int.Parse(Console.ReadLine());
        List<Engine> engines = new List<Engine>();
        List<Car> cars = new List<Car>();

        for (int i = 0; i < countOfEngines; i++)
        {
            string[] currentEngineDetails = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string model = currentEngineDetails[0];
            int power = int.Parse(currentEngineDetails[1]);

            Engine currentEngine = new Engine(model, power);
            double displacement;
            string efficiency;

            switch (currentEngineDetails.Length)
            {
                case 3:
                    if (Char.IsDigit(currentEngineDetails[2][0]))
                    {
                        displacement = double.Parse(currentEngineDetails[2]);
                        currentEngine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        efficiency = currentEngineDetails[2];
                        currentEngine = new Engine(model, power, efficiency);
                    }
                    break;
                case 4:
                    displacement = double.Parse(currentEngineDetails[2]);
                    efficiency = currentEngineDetails[3];
                    currentEngine = new Engine(model, power, displacement, efficiency);
                    break;
            }

            engines.Add(currentEngine);
        }

        int countOfCars = int.Parse(Console.ReadLine());

        for (int i = 0; i < countOfCars; i++)
        {
            string[] currentCarDetails = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = currentCarDetails[0];
            Engine engine = engines.Where(x => x.Model == currentCarDetails[1]).FirstOrDefault();

            Car currentCar = new Car(model, engine);
            double weight;
            string color;
            switch (currentCarDetails.Length)
            {
                case 3:
                    if (Char.IsDigit(currentCarDetails[2][0]))
                    {
                        weight = double.Parse(currentCarDetails[2]);
                        currentCar = new Car(model, engine, weight);
                    }
                    else
                    {
                        color = currentCarDetails[2];
                        currentCar = new Car(model, engine, color);
                    }
                    break;
                case 4:
                    weight = double.Parse(currentCarDetails[2]);
                    color = currentCarDetails[3];
                    currentCar = new Car(model, engine, weight, color);
                    break;
            }

            cars.Add(currentCar);
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }
}
