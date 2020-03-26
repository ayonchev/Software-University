using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string result = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            Console.WriteLine(result);
        }
    }
}
