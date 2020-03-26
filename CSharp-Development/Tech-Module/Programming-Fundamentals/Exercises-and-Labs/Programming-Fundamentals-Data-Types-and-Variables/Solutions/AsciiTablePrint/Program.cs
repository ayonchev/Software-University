using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiTablePrint
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());
            int endingNumber = int.Parse(Console.ReadLine());
            string result = "";

            for (char i = (char)startingNumber; i <= (char)endingNumber; i++)
            {
                result += i + " ";
            }
            Console.WriteLine(result);
        }
    }
}
