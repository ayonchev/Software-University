namespace GameOfNumbers
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var startingNumber = int.Parse(Console.ReadLine());
            var endingNumber = int.Parse(Console.ReadLine());
            var magicalNumber = int.Parse(Console.ReadLine());
            var sum = "";
            var isFound = false;
            var numberOfCombinations = 0;

            for (int firstNumber = startingNumber; firstNumber <= endingNumber; firstNumber++)
            {
                for (int secondNumber = startingNumber; secondNumber <= endingNumber; secondNumber++)
                {
                    if (firstNumber + secondNumber == magicalNumber)
                    {
                        sum = $"{firstNumber} + {secondNumber} = {magicalNumber}";
                        isFound = true;
                    }
                    else
                    {
                        numberOfCombinations++;
                    }
                }
            }

            if (isFound == true)
            {
                Console.WriteLine($"Number found! {sum}");
            }
            else
            {
                Console.WriteLine($"{numberOfCombinations} combinations - neither equals {magicalNumber}");
            }
        }
    }
}
