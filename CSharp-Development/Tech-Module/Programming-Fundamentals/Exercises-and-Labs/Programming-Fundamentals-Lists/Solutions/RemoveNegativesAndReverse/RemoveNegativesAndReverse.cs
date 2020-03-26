using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> resultList = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] >= 0)
                {
                    resultList.Add(inputList[i]);
                }
            }

            resultList.Reverse();

            if (resultList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", resultList));
            }
        }
    }
}