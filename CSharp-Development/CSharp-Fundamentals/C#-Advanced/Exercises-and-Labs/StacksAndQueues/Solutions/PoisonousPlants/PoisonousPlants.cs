using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonousPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            //77 / 100
            int n = int.Parse(Console.ReadLine());

            List<int> plants = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Stack<int> plantsToRemove = new Stack<int>();
            int days = 0;

            while (true)
            {
                for (int i = 1; i < plants.Count; i++)
                {
                    if (plants[i] > plants[i - 1])
                    {
                        plantsToRemove.Push(i);
                    }
                }

                if (plantsToRemove.Count == 0)
                {
                    Console.WriteLine(days);
                    break;
                }
                else
                {
                    while (plantsToRemove.Count > 0)
                    {
                        plants.RemoveAt(plantsToRemove.Pop());
                    }
                }

                days++;
            }
        }
    }
}
