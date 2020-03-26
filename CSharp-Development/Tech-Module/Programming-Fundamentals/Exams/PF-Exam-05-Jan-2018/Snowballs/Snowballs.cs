using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Snowballs
{
    class Snowballs
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            BigInteger maxSnowballValue = int.MinValue;
            int maxSnowballSnow = 0;
            int maxSnowballTime = 0;
            int maxSnowballQuality = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger currentSnowballValue = snowballSnow / snowballTime;

                BigInteger resultSnowballValue = 1;

                for (int j = 0; j < snowballQuality; j++)
                {
                    resultSnowballValue *= currentSnowballValue;
                }

                if (resultSnowballValue > maxSnowballValue)
                {
                    maxSnowballValue = resultSnowballValue;
                    maxSnowballQuality = snowballQuality;
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                }
            }

            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxSnowballValue} ({maxSnowballQuality})");
        }
    }
}
