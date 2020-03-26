using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                string currentElement = Convert.ToString(inputList[i]);
                string newElement = "";
                
                for (int j = currentElement.Length - 1; j >= 0; j--)
                {
                    newElement += currentElement[j];
                }

                inputList[i] = (Convert.ToInt32(newElement));
                sum += inputList[i];
            }
            Console.WriteLine(sum);
        }
    }
}
