using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMonDontGo
{
    class PokemonDontGo
    {
        static void Main(string[] args)
        {
            List<long> inputList = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            List<long> result = new List<long>();
            while (inputList.Count > 0)
            {
                int currentIndex = int.Parse(Console.ReadLine());
                long currentNumber = 0;
                bool isLast = false;
                bool isFirst = false;

                if (currentIndex < 0)
                {
                    currentIndex = 0;
                    isFirst = true;
                }
                else if (currentIndex > inputList.Count - 1)
                {
                    currentIndex = inputList.Count - 1;
                    isLast = true;
                }

                currentNumber = inputList[currentIndex];
                inputList.RemoveAt(currentIndex);
                result.Add(currentNumber);

                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i] <= currentNumber)
                    {
                        inputList[i] += currentNumber;
                    }
                    else
                    {
                        inputList[i] -= currentNumber;
                    }
                }

                if (isFirst == true)
                {
                    inputList.Insert(0, inputList[inputList.Count - 1]);
                }
                else if (isLast == true)
                {
                    inputList.Insert(inputList.Count, inputList[0]);
                }
            }

            Console.WriteLine(result.Sum());
        }
    }
}
