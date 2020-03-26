using System;
using System.Collections.Generic;
using System.Linq;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            result.Add("Pesho", 20);
            result.Add("Gosho", 8);
            result.Add("Strahil", 51);
            result.Add("Misho", 12);

            var above18 = result.Where(x => x.Value > 18).Count();
            Console.WriteLine(Math.Ceiling(5.0 / 3.0));
        }
    }
}
