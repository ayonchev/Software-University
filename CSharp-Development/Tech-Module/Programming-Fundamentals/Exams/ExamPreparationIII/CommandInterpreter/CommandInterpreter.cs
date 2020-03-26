using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine()
                .Split(new char[] { ' ', '\t'}, 
                StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                string[] currentCommand = Console.ReadLine()
                    .Split(new char[] { ' ', '\t' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Where(x => x != "from" && x != "times" && x != "count")
                    .ToArray();

                if (currentCommand[0] != "end")
                {
                    bool isValid = IsInputValid(currentCommand, inputData);

                    if (isValid)
                    {
                        if (currentCommand[0] == "reverse")
                        {
                            inputData = ReverseArray(currentCommand, inputData);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", inputData));
        }

        static string[] ReverseArray(string[] currentCommand, string[] inputData)
        {
            int startIndex = int.Parse(currentCommand[1]);
            int endIndex = startIndex + int.Parse(currentCommand[2]) - 1;

            for (int i = startIndex; i < endIndex; i++)
            {
                var temp = inputData[i];
                inputData[i] = inputData[endIndex];
                inputData[endIndex] = temp;
                endIndex--;
            }

            return inputData;
        }

        static bool IsInputValid(string[] currentCommand, string[] inputData)
        {
            int count = 0;
            int start = 0;

            if (currentCommand.Length == 2)
            {
                count = int.Parse(currentCommand[1]);
            }
            else if (currentCommand.Length == 3)
            {
                start = int.Parse(currentCommand[1]);
                count = int.Parse(currentCommand[2]);
            }

            if (start < 0 || start + count >= inputData.Length || count < 0)
            {
                return false;
            }
            return true;
        }
    }
}
