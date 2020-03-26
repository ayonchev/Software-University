using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

public class RaceTower
{
    private List<Driver> racingDrivers;
    private Dictionary<Driver, string> failedDrivers;
    private int totalLaps;
    private int currentLap;
    private int trackLength;
    private Weather weather;

    public RaceTower()
    {
        this.currentLap = 0;
        this.weather = Weather.Sunny;
    }
    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        this.totalLaps = lapsNumber;
        this.trackLength = trackLength;
    }
    public void RegisterDriver(List<string> commandArgs)
    {
        try
        {
            Driver newDriver = DriverFactory.CreateDriver(commandArgs);

            if (newDriver != null)
            {
                racingDrivers.Add(newDriver);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void DriverBoxes(List<string> commandArgs)
    {
        string type = commandArgs[0];
        string name = commandArgs[1];
        Driver currentDriver = racingDrivers.FirstOrDefault(d => d.Name == name);

        commandArgs = commandArgs.Skip(2).ToList();
        switch (type)
        {
            case "Refuel":
                currentDriver.Car.Refuel(commandArgs);
                break;
            case "ChangeTyres":
                currentDriver.Car.ChangeTyres(commandArgs);
                break;
        }

        currentDriver.TotalTime += 20;
    }

    public string CompleteLaps(List<string> commandArgs)
    {
        int numberOfLaps = int.Parse(commandArgs[0]);
        if (numberOfLaps + currentLap > totalLaps)
        {
            return $"There is no time! On lap {currentLap}.";
        }
        else
        {
            for (int lapNumber = 1; lapNumber <= numberOfLaps; lapNumber++)
            {
                currentLap += lapNumber;

                racingDrivers.ForEach(d => d.TotalTime += 60 / (trackLength / d.Speed));
                racingDrivers = racingDrivers.OrderBy(d => d.TotalTime).ToList();

                //racingDrivers.ForEach(d => d.Car.FuelAmount -= trackLength * d.FuelConsumptionPerKm);
                //racingDrivers.ForEach(d => d.Car.CompleteLap());
                Overtake();
            }
        }

        return null;
    }

    public void Overtake()
    {
        for (int driverIndex = racingDrivers.Count - 1; driverIndex > 0; driverIndex--)
        {
            if (racingDrivers[driverIndex - 1].TotalTime - racingDrivers[driverIndex].TotalTime <= 2)
            {
                racingDrivers[driverIndex].TotalTime -= 2;
                racingDrivers[driverIndex - 1].TotalTime += 2;

                Console.WriteLine($"{racingDrivers[driverIndex].Name} has overtaken {racingDrivers[driverIndex - 1].Name} on lap {currentLap}.");
            }
            else if (racingDrivers[driverIndex - 1].TotalTime - racingDrivers[driverIndex].TotalTime <= 3)
            {
                if ((racingDrivers[driverIndex] is AggressiveDriver &&
                    racingDrivers[driverIndex].Car.Tyre is UltrasoftTyre &&
                    this.weather == Weather.Foggy) ||
                    (racingDrivers[driverIndex] is EnduranceDriver &&
                    racingDrivers[driverIndex].Car.Tyre is HardTyre &&
                     this.weather == Weather.Rainy))
                {
                    this.failedDrivers.Add(racingDrivers[driverIndex], "Crashed");
                    this.racingDrivers.RemoveAt(driverIndex);
                    driverIndex++;
                }
                else
                {
                    racingDrivers[driverIndex].TotalTime -= 3;
                    racingDrivers[driverIndex - 1].TotalTime += 3;
                    Console.WriteLine($"{racingDrivers[driverIndex].Name} has overtaken {racingDrivers[driverIndex - 1].Name} on lap {currentLap}.");
                }
            }
        }
    }

    public string GetLeaderboard()
    {
        string result = $"Lap {currentLap}/{totalLaps}" + Environment.NewLine;
        int count = 1;

        foreach (var driver in racingDrivers.OrderBy(d => d.TotalTime))
        {
            result += $"{count++} {driver.Name} {driver.TotalTime}";
        }

        foreach (var failedDriver in failedDrivers)
        {
            result += $"{count++} {failedDriver.Key.Name} {failedDriver.Value}";
        }

        return result;
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        Weather newWeatherState;
        if (Weather.TryParse(commandArgs[0], out newWeatherState))
        {
            this.weather = newWeatherState;
        }
    }
}

