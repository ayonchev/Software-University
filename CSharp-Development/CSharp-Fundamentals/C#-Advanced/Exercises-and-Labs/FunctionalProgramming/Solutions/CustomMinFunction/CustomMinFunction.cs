using System;
using System.Linq;

namespace CustomMinFunction
{
    class CustomMinFunction
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> findSmallestElement = allNumbers =>
            {
                int minNumber = int.MaxValue;
                foreach (var number in allNumbers)
                {
                    if (number < minNumber)
                    {
                        minNumber = number;
                    }
                }
                return minNumber;
            };

            Console.WriteLine(findSmallestElement(numbers));
        }
    }
}
