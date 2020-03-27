using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> resultList = new List<int>();

            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < inputArray[0]; i++)
            {
                resultList.Add(inputList[i]);
            }

            for (int i = 0; i < inputArray[1]; i++)
            {
                resultList.RemoveAt(0);
            }

            if (resultList.Contains(inputArray[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
