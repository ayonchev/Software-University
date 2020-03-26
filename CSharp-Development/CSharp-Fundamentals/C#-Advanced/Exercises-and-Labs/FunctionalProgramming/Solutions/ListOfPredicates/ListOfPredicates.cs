using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class ListOfPredicates
    {
        static void Main()
        {
            int endNumber = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            int[] divisors = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToArray();

            Func<int, int[], bool> filter = (number, allDivisors) =>
            {
                foreach (var divisor in allDivisors)
                {
                    if (number % divisor != 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            for (int i = 1; i <= endNumber; i++)
            {
                if (filter(i, divisors))
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
