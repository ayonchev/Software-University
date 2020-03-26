using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "phaha put";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'p')
                {
                    string newInput = input.Substring(i, 1);
                    Console.WriteLine(newInput);
                }
            }

        }
    }
}
