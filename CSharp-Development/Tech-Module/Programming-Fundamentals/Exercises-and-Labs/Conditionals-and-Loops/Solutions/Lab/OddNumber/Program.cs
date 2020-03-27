using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfIteractions = 1;

            while (numberOfIteractions <= 10)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    break;
                }
                numberOfIteractions++;
            }
        }
    }
}
