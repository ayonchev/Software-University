using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            int numberOfPetrolPumps = int.Parse(Console.ReadLine());

            Queue<int[]> allPumps = new Queue<int[]>();
            int index = 0;

            for (int i = 0; i < numberOfPetrolPumps; i++)
            {
                int[] currentPump = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                allPumps.Enqueue(currentPump);
            }

            for (int i = 0; i < numberOfPetrolPumps; i++)
            {
                int petrolAmount = 0;
                int distance = 0;
                bool isCurrentPumpStart = true;

                foreach (var pump in allPumps)
                {
                    petrolAmount += pump[0];
                    distance += pump[1];

                    if (petrolAmount < distance)
                    {
                        isCurrentPumpStart = false;
                        break;
                    }
                }

                if (isCurrentPumpStart)
                {
                    index = i;
                    break;
                }
                else
                {
                    allPumps.Enqueue(allPumps.Dequeue());
                }
            }

            Console.WriteLine(index);
        }
    }
}
