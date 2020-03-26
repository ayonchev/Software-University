using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            var resultDict = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split('|').ToArray();

                if (input[0] != "report")
                {
                    string city = input[0];
                    string country = input[1];
                    long population = long.Parse(input[2]);

                    if (!resultDict.ContainsKey(country))
                    {
                        resultDict.Add(country, new Dictionary<string, long>());
                        resultDict[country].Add(city, population);
                    }
                    else
                    {
                        resultDict[country].Add(city, population);
                    }
                }
                else
                {
                    break;
                }
            }

            foreach (var country in resultDict.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                Dictionary<string, long> cityDetails = country.Value;

                foreach (var city in cityDetails.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
