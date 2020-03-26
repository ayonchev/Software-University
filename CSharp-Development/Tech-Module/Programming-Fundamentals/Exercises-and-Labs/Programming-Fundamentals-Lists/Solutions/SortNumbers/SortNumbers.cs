using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> inputList = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            inputList.Sort();

            Console.WriteLine(string.Join(" <= ", inputList));
        }
    }
}
