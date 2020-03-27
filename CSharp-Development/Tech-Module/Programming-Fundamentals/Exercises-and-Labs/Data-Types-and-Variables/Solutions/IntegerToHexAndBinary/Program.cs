using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string hexRepresentation = Convert.ToString(number, 16);
            hexRepresentation = hexRepresentation.ToUpper();

            string binaryRepresentation = Convert.ToString(number, 2);

            //int currNum = Convert.ToInt32(binaryRepresentation);
            Console.WriteLine(hexRepresentation);
            Console.WriteLine(binaryRepresentation);
            //Console.WriteLine(currNum);
        }
    }
}
