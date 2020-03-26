using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPotato
{
    class MathPotato
    {
        static void Main(string[] args)
        {
            var children = Console.ReadLine().Split(' ');
            var number = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(children);
            int cycle = 1;

            while (queue.Count != 1)
            {
                for (int i = 1; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                if (IsPrime(cycle))
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                else
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }

                cycle++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }

        static bool IsPrime(int currentCycle)
        {
            for (int i = 1; i < Math.Sqrt(currentCycle); i++)
            {
                if (currentCycle % i == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
