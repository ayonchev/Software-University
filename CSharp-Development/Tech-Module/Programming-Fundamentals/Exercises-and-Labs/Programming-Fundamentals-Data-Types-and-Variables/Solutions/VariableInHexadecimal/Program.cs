using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexNumber = Console.ReadLine();

            int intNum = Convert.ToInt32(hexNumber, 16);

            Console.WriteLine(intNum);
        }
    }
}
