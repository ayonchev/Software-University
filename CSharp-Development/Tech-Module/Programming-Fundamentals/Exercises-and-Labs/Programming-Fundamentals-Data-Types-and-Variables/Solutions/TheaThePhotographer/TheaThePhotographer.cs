using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntegerSize
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            long totalPics = long.Parse(Console.ReadLine());
            long filterTimeInSeconds = long.Parse(Console.ReadLine());
            double percentageOfTotalPics = double.Parse(Console.ReadLine());
            percentageOfTotalPics /= 100;

            long uploadingTimeInSeconds = long.Parse(Console.ReadLine());

            long usefulPics = (long)(Math.Ceiling((double)totalPics * percentageOfTotalPics));

            long timeNeededInSeconds = totalPics * filterTimeInSeconds + usefulPics * uploadingTimeInSeconds;

            long seconds = timeNeededInSeconds % 60;
            long minutes = timeNeededInSeconds / 60;
            long hours = minutes / 60;
            long days = hours / 24;

            if (minutes > 59)
            {
                minutes = minutes % 60;
            }

            if (hours > 23)
            {
                hours = hours % 24;
            }
            Console.WriteLine($"{days:D1}:{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
