using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        TrafficLightFactory factory = new TrafficLightFactory();

        string[] inputLights = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        List<TrafficLight> trafficLights = new List<TrafficLight>();

        for (int index = 0; index < inputLights.Length; index++)
        {
            var currentTrafficLight = factory.CreateTrafficLight(inputLights[index]);
            trafficLights.Add(currentTrafficLight);
        }

        int numberOfUpdates = int.Parse(Console.ReadLine());

        for (int index = 0; index < numberOfUpdates; index++)
        {
            trafficLights.ForEach(t => t.Update());
            Console.WriteLine(string.Join(" ", trafficLights));
        }
    }
}
