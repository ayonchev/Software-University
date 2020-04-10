using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateSequenceWithAQueue
{
    class Program
    {
        private static int numbersCount = 50;
        private static int numbersCountPerIteration = 3;
        private static int iterations = numbersCount / numbersCountPerIteration;

        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            SolutionWithOneQueue(startNumber);
        }

        static void SolutionWithOneQueue(int startNumber)
        {
            string format = "{0}, ";
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(startNumber);

            Console.Write(string.Format(format, startNumber));
            int count = 1;

            while (count < iterations)
            {
                int workSum = numbers.Dequeue();

                int firstMember = workSum + 1;
                int secondMember = (workSum * 2) + 1;
                int thirdMember = workSum + 2;

                Console.Write(string.Format(format, firstMember));
                Console.Write(string.Format(format, secondMember));
                Console.Write(string.Format(format, thirdMember));

                count += 3;
                numbers.Enqueue(firstMember);
                numbers.Enqueue(secondMember);
                numbers.Enqueue(thirdMember);
            }

            Console.WriteLine(numbers.Dequeue() + 1);
        }

        static void SolutionWithTwoQueues(int startNumber)
        {
            Queue<int> numbers = new Queue<int>();
            Queue<int> dequeuedSums = new Queue<int>();

            numbers.Enqueue(startNumber);

            for (int i = 0; i < iterations; i++)
            {
                int currentSum = numbers.Dequeue();

                numbers.Enqueue(currentSum + 1);
                numbers.Enqueue((currentSum * 2) + 1);
                numbers.Enqueue(currentSum + 2);

                dequeuedSums.Enqueue(currentSum);
            }

            numbers.Enqueue(numbers.Peek() + 1);
            StringBuilder result = new StringBuilder();

            foreach (var number in dequeuedSums)
            {
                result.Append($"{number}, ");
            }

            foreach (var number in numbers)
            {
                result.Append($"{number}, ");
            }

            result.Remove(result.Length - 2, 2);
            Console.WriteLine(result);
        }
    }
}
