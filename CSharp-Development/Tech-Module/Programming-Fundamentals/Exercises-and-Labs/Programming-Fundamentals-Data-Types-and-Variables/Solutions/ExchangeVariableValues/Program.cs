using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 10;
            var c = a;

            Console.WriteLine($"Before: \na = {a}\nb = {b}");

            a = b;
            b = c;
            Console.WriteLine($"After: \na = {a}\nb = {b}");
        }
    }
}
