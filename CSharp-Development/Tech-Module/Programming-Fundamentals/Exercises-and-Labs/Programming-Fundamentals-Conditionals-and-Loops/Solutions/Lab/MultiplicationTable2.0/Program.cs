using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var multiplicationNum = int.Parse(Console.ReadLine());
            var startingNum = int.Parse(Console.ReadLine());

            /*if (startingNum <= 10)
            {
                for (int i = startingNum; i <= 10; i++)
                {
                    Console.WriteLine($"{multiplicationNum} X {i} = {multiplicationNum * i}");
                }
            }
            else
            {
                Console.WriteLine($"{multiplicationNum} X {startingNum} = {multiplicationNum * startingNum}");
            }*/
            do
            {
                Console.WriteLine($"{multiplicationNum} X {startingNum} = {multiplicationNum * startingNum}");
                startingNum++;
            } while (startingNum <= 10);
        }
    }
}
