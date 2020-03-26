
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Weather
{
    class Weather
    {
        static void Main(string[] args)
        {
            Dictionary<string, CityProperties> result = new Dictionary<string, CityProperties>();

            while (true)
            {
                string input = Console.ReadLine();

                string pattern = @"([A-Z]{2})(\d+\.\d+)([a-zA-Z]+)\|";

                if (input == "end")
                {
                    break;
                }
                else if (Regex.IsMatch(input, pattern))
                {
                    string nameOfCity = Regex.Match(input, pattern).Groups[1].Value;
                    double averageTemperature = Convert.ToDouble(Regex.Match(input, pattern).Groups[2].Value);
                    string typeOfWeather = Regex.Match(input, pattern).Groups[3].Value;

                    if (result.ContainsKey(nameOfCity))
                    {
                        result[nameOfCity].AverageTemperature = averageTemperature;
                        result[nameOfCity].TypeOfWeather = typeOfWeather;
                    }
                    else
                    {
                        CityProperties currentProperties = new CityProperties();
                        currentProperties.AverageTemperature = averageTemperature;
                        currentProperties.TypeOfWeather = typeOfWeather;

                        result.Add(nameOfCity, currentProperties);
                    }
                }
                else
                {
                    continue;
                }
            }

            foreach (var city in result.OrderBy(x => x.Value.AverageTemperature))
            {
                Console.WriteLine($"{city.Key} => {city.Value.AverageTemperature:F2} => {city.Value.TypeOfWeather}");
            }
        }
    }
}
