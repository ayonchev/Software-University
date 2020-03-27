using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> resultList = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (Math.Sqrt(inputList[i]) == (int)Math.Sqrt(inputList[i]))
                {
                    resultList.Add(inputList[i]);
                }
            }

            resultList.Sort();

            for (int i = resultList.Count - 1; i >= 0; i--)
            {
                Console.Write(resultList[i] + " ");
            }
        }
    }
}
