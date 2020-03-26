using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class FindEvensOrOdds
    {
        static void Main()
        {
            int[] range = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string condition = Console.ReadLine();

            List<int> numbers = new List<int>();

            for (int i = range[0]; i <= range[1]; i++)
            {
                numbers.Add(i);
            }


            Predicate<string> checkCondition = currCondition =>
            {
                if (condition == "even")
                {
                    return true;
                }
                return false;
            };
            

            if (checkCondition(condition))
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));

            }
        }
    }
}
