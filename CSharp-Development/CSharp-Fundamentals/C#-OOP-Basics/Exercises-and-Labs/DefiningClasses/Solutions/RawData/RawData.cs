using System;
using System.Collections.Generic;
using System.Linq;

public class RawData
{
    static void Main()
    {
        int countOfCars = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < countOfCars; i++)
        {
            string[] currentCarDetails =
                Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = currentCarDetails[0];
            int engineSpeed = int.Parse(currentCarDetails[1]);
            int enginePower = int.Parse(currentCarDetails[2]);
            int cargoWeight = int.Parse(currentCarDetails[3]);
            string currentCarCargoType = currentCarDetails[4];
            double firstTirePressure = double.Parse(currentCarDetails[5]);
            int firstTireAge = int.Parse(currentCarDetails[6]);
            double secondTirePressure = double.Parse(currentCarDetails[7]);
            int secondTireAge = int.Parse(currentCarDetails[8]);
            double thirdTirePressure = double.Parse(currentCarDetails[9]);
            int thirdTireAge = int.Parse(currentCarDetails[10]);
            double fourthTirePressure = double.Parse(currentCarDetails[11]);
            int fourthTireAge = int.Parse(currentCarDetails[12]);

            Car currentCar = new Car(
                model, engineSpeed, enginePower, cargoWeight, currentCarCargoType, 
                firstTirePressure, firstTireAge, secondTirePressure, secondTireAge, 
                thirdTirePressure, thirdTireAge, fourthTirePressure, fourthTireAge);

            cars.Add(currentCar);
        }

        string cargoType = Console.ReadLine();

        switch (cargoType)
        {
            case "flamable":
                foreach (var car in cars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250))
                {
                    Console.WriteLine(car.Model);
                }
                break;
            case "fragile":
                foreach (var car in cars.Where(x => x.Cargo.CargoType == "fragile" && x.Tires.Any(t => t.TirePressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
                break;
        }
    }
}

