using System;
using System.Collections.Generic;
using System.Linq;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = "23/5/1980";
            DateTime currdate = DateTime.Parse(date);
            Console.WriteLine(currdate);
        }
    }
}
