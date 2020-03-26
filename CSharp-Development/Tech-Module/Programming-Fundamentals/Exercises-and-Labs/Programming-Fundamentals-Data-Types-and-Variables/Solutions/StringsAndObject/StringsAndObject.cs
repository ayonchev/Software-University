using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObject
{
    class StringsAndObject
    {
        static void Main(string[] args)
        {
            string firstString = "Hello";
            string secondString = "World";
            object obj = firstString + " " + secondString;
            Console.WriteLine((string)obj);
        }
    }
}
