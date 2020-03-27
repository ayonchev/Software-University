using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string personName = Console.ReadLine();
            PrintName(personName);
        }
        static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
