using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp1
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.ParseExact(Console.ReadLine(), 
                "H:mm:s", 
                CultureInfo.InvariantCulture);
            int numberOfSteps = int.Parse(Console.ReadLine()) % 86400;
            int timeForStep = int.Parse(Console.ReadLine()) % 86400;
            long result = numberOfSteps * timeForStep;

            long minutes = result / 60;
            long seconds = result % 60;

            currentTime = currentTime.AddMinutes(minutes).AddSeconds(seconds);
            Console.WriteLine("Time Arrival: " + currentTime.ToString("HH:mm:ss"));
        }
    }
}
