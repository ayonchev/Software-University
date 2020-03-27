using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> numbers = new List<int>();
            List<int> occurences = new List<int>();

            inputList.Sort();

            int count = 1;

            for (int i = 0; i < inputList.Count; i++)
            {
                if (i + 1 < inputList.Count)
                {
                    if (inputList[i] == inputList[i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        numbers.Add(inputList[i]);
                        occurences.Add(count);
                        count = 1;
                    }
                }
                else
                {
                    numbers.Add(inputList[i]);
                    occurences.Add(count);
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i] + " - > " + occurences[i]);
            }
        }
    }
}
