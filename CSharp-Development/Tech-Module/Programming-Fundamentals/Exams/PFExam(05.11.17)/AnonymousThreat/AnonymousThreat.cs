using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main(string[] args)
        {
            //80/100 points

            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries);
            List<string> resultList = new List<string>();

            while (true)
            {
                string[] currentCommand = Console.ReadLine()
                    .Split(new char[] { ' ', '\t' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (currentCommand[0] != "3:1")
                {
                    if (currentCommand[0] == "merge")
                    {
                        resultList = MergeStrings(currentCommand, input);
                        input = resultList.ToArray();
                    }
                    else if (currentCommand[0] == "divide")
                    {
                        resultList = DivideString(currentCommand, input);
                        input = resultList.ToArray();
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

            Console.WriteLine(string.Join(" ", resultList));
        }

        static List<string> DivideString(string[] currentCommand, string[] input)
        {
            int index = int.Parse(currentCommand[1]);
            int parts = int.Parse(currentCommand[2]);
            int currentLength = 0;
            string currentWord = input[index];

            List<string> dividedList = new List<string>();
            List<string> result = input.ToList();

            if (parts <= 0)
            {
                return result;
            }
            else
            {
                currentLength = currentWord.Length / parts;
            }

            for (int i = 0; i < parts - 1; i++)
            {
                string currentPart = currentWord.Substring(0, currentLength);
                dividedList.Add(currentPart);
                currentWord = currentWord.Substring(currentLength, currentWord.Length - currentLength);
            }
            dividedList.Add(currentWord);

            result.RemoveAt(index);
            result.InsertRange(index, dividedList);

            return result;
        }

        static List<string> MergeStrings(string[] currentCommand, string[] input)
        {
            int startIndex = int.Parse(currentCommand[1]);
            int endIndex = int.Parse(currentCommand[2]);
            List<string> mergedList = input.ToList();
            string mergedResult = "";

            if (endIndex > input.Length || endIndex < 0)
            {
                endIndex = input.Length - 1;
            }
            if (startIndex >= input.Length - 1 || startIndex < 0)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                mergedResult = string.Concat(mergedResult, input[i]);
            }

            mergedList.RemoveRange(startIndex, endIndex - startIndex + 1);
            mergedList.Insert(startIndex, mergedResult);

            return mergedList;
        }
    }
}
