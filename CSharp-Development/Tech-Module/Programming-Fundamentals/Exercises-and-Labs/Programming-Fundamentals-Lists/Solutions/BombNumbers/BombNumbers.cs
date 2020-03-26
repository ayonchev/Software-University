using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int specialNumber = inputArray[0];
            int detonatingNumbers = inputArray[1];

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] == specialNumber)
                {
                    if (i - detonatingNumbers >= 0 && i + detonatingNumbers <= inputList.Count - 1)
                    {
                        inputList.RemoveRange(i - detonatingNumbers, 2 * detonatingNumbers + 1);
                    }
                    else if (i == 0)
                    {
                        inputList.RemoveRange(0, detonatingNumbers + 1);
                    }
                    else if (i != 0 && i - detonatingNumbers < 0)
                    {
                        inputList.RemoveRange(0, detonatingNumbers + detonatingNumbers - i);
                    }
                    else if (i == inputList.Count - 1)
                    {
                        inputList.RemoveRange(inputList.Count - 1 - detonatingNumbers, detonatingNumbers);
                    }
                    else if (i != inputList.Count - 1 && i + detonatingNumbers > inputList.Count)
                    {
                        inputList.RemoveRange(i - detonatingNumbers, inputList.Count - 1 - i + detonatingNumbers + 1);
                    }
                }
            }
            
            Console.WriteLine(inputList.Sum());
        }
    }
}
