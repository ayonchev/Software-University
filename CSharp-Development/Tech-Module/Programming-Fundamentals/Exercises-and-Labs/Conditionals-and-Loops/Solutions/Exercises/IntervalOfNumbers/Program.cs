
namespace IntervalOfNumbers
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            if (firstNum < secondNum)
            {
                for (int i = firstNum; i <= secondNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = secondNum; i <= firstNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
