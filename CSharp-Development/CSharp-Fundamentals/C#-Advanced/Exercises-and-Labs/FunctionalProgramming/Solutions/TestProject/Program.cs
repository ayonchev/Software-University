using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3};

            numbers.Add(4);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
