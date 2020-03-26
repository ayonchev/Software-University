using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());

            int pokePower = power;
            int targets = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                targets++;

                if (pokePower * 2.0 == (double)power)
                {
                    if (exhaustionFactor > 0)
                    {
                        pokePower /= exhaustionFactor;
                        continue;
                    }
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targets);
        }
    }
}
