
namespace TestNumbers
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());
            var sum = 0;
            var numberOfIterations = 0;

            for (int firstDigit = firstNum; firstDigit >= 1; firstDigit--)
            {
                for (int secondDigit = 1; secondDigit <= secondNum; secondDigit++)
                {
                    numberOfIterations++;
                    sum += ((firstDigit * secondDigit) * 3);

                    if (sum >= maxSum)
                    {
                        break;
                    }   
                }
                if (sum >= maxSum)
                {
                    break;
                }
            }

            if (sum < maxSum)
            {
                Console.WriteLine($"{numberOfIterations} combinations\nSum: {sum}");
            }
            else
            {
                Console.WriteLine($"{numberOfIterations} combinations\nSum: {sum} >= {maxSum}");
            }
        }
    }
}
