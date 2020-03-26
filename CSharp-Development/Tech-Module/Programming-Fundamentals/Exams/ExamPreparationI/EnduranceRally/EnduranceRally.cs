using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class EnduranceRally
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split(' ');
            double[] zones = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            int[] checkpoints = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();


            foreach (var driver in drivers)
            {
                double currentFuel = driver.First();

                for (int i = 0; i < zones.Length; i++)
                {
                    if (checkpoints.Any(x => x == i))
                    {
                        currentFuel += zones[i];
                    }
                    else
                    {
                        currentFuel -= zones[i];
                    }

                    if (currentFuel <= 0)
                    {
                        Console.WriteLine(driver + " - reached " + i);
                        break;
                    }
                }

                if (currentFuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {currentFuel:f2}");
                }
            }
        }
    }
}
