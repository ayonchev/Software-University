using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMetres = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float timeInSeconds = hours * 60 * 60 + minutes * 60 + seconds;
            float timeInHours = hours + minutes / 60 + ((seconds / 60) / 60);

            float distanceInKm = distanceInMetres / 1000;
            float distanceInMiles = distanceInMetres / 1609;

            float metresPerSecond = distanceInMetres / timeInSeconds;
            float kmPerHour = distanceInKm / timeInHours;
            float milesPerHour = distanceInMiles / timeInHours;

            Console.WriteLine(metresPerSecond);
            Console.WriteLine(kmPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
