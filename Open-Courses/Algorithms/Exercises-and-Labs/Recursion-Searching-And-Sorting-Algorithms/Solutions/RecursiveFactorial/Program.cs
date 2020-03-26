using System;

namespace RecursiveFactorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            int factorialNumber = int.Parse(Console.ReadLine());

            long factorial = GetFactorial(factorialNumber);
            Console.WriteLine(factorial);
        }

        static long GetFactorial(int currentNumber)
        {
            if (currentNumber == 1)
                return 1;

            long previousNumbersFactorial = GetFactorial(currentNumber - 1);
            long currentTotal = currentNumber * previousNumbersFactorial;
            return currentTotal;
        }
    }
}
