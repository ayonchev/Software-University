using System;
using System.Globalization;
using System.Linq;

namespace AppliedArithmetics
{
    class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int[]> add = nums => nums = nums.Select(x => x += 1).ToArray();
            Func<int[], int[]> multiply = nums => nums = nums.Select(x => x *= 2).ToArray();
            Func<int[], int[]> substract = nums => nums = nums.Select(x => x -= 1).ToArray();
            Action<int[]> print = nums => Console.WriteLine(string.Join(" ", nums));

            while (true)
            {
                string command = Console.ReadLine();

                if (command != "end")
                {
                    switch (command)
                    {
                        case "add":
                            numbers = add(numbers);
                            break;
                        case "multiply":
                            numbers = multiply(numbers);
                            break;
                        case "subtract":
                            numbers = substract(numbers);
                            break;
                        case "print":
                            print(numbers);
                            break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
