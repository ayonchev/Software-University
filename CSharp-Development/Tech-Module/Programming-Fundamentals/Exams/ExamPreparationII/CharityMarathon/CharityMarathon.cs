using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            long numberOfDays = long.Parse(Console.ReadLine());
            long numberOfRunners = long.Parse(Console.ReadLine());
            long averageNumberOfLaps = long.Parse(Console.ReadLine());
            long lengthOfTrack = long.Parse(Console.ReadLine());
            long capacity = long.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            if (numberOfDays * capacity < numberOfRunners)
            {
                numberOfRunners = numberOfDays * capacity;
            }

            ulong totalKm = (ulong)(numberOfRunners * averageNumberOfLaps * lengthOfTrack) / 1000;
            double totalMoney = totalKm * moneyPerKm;

            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}
