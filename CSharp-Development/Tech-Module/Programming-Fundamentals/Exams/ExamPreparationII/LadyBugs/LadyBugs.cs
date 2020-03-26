using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    class LadyBugs
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugIndexes = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] resultArray = new int[fieldSize];

            for (int i = 0; i < resultArray.Length; i++)
            {
                if (ladyBugIndexes.Any(x => x == i))
                {
                    resultArray[i] = 1;
                }
                else
                {
                    resultArray[i] = 0;
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input[0] != "end")
                {
                    int currentIndex = int.Parse(input[0]);
                    string direction = input[1];
                    int step = int.Parse(input[2]);

                    if (currentIndex < 0 || currentIndex >= resultArray.Length)
                    {
                        continue;
                    }

                    if (resultArray[currentIndex] == 1)
                    {
                        resultArray[currentIndex] = 0;

                        if (direction == "right")
                        {
                            for (int i = currentIndex + step; i < resultArray.Length; i += step)
                            {
                                if (resultArray[i] == 0)
                                {
                                    resultArray[i] = 1;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            for (int i = currentIndex - step; i >= 0; i -= step)
                            {
                                if (resultArray[i] == 0)
                                {
                                    resultArray[i] = 1;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
