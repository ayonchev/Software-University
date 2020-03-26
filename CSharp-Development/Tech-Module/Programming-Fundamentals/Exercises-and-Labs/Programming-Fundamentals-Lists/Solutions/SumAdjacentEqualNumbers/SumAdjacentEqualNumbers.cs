using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> inputList = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            bool hasSummed = true;

            while (hasSummed)
            {
                hasSummed = false;

                int index = 0;
                decimal sum = 0;

                for (int i = 1; i < inputList.Count; i++)
                {
                    if (inputList[i] == inputList[i - 1])
                    {
                        index = i - 1;
                        sum = inputList[i] + inputList[i - 1];
                        hasSummed = true;
                        break;
                    }
                }

                if (hasSummed)
                {
                    inputList.RemoveRange(index, 2);
                    inputList.Insert(index, sum);
                }
            }

            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
