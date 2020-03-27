using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            double[] inputArray = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var result = new SortedDictionary<double, int>();

            foreach (var number in inputArray)
            {
                if (result.ContainsKey(number))
                {
                    result[number]++;
                }
                else
                {
                    result.Add(number, 1);
                    //result[number] = 1;
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
