using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            inputList = SumPairs(inputList);
            Console.WriteLine(string.Join(" ", inputList));
        }

        static List<int> SumPairs(List<int> inputList)
        {
            List<int> newList = new List<int>();
            int index = 0;

            for (int i = 0; i < inputList.Count; i += 2)
            {
                if (i + 1 < inputList.Count)
                {
                    newList.Insert(index, inputList[i] + inputList[i + 1]);
                }

                index++;
            }
            inputList = newList;
            return inputList;
        }
    }
}
