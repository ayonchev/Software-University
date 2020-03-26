using System;
using System.Linq;

namespace FindingTheSumOfNumbers
{
    public class Program
    {
        static int[] numbers;
        static void Main(string[] args)
        {
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = 0;
            int sum = SumNumbers(index);
            Console.WriteLine(sum);
        }

        static int SumNumbers(int index)
        {
            if (index == numbers.Length - 1)
                return numbers[index];

            var currentSum = numbers[index] + SumNumbers(index + 1);
            return currentSum;
        }
    }
}
