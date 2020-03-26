using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string[] currentCommand = Console.ReadLine().Split(' ').ToArray();

                if (currentCommand[0] == "print")
                {
                    Console.WriteLine("[" + string.Join(", ", inputList) + "]");
                    break;
                }
                else if (currentCommand[0] == "add")
                {
                    int index = int.Parse(currentCommand[1]);
                    int element = int.Parse(currentCommand[2]);
                    inputList.Insert(index, element);
                }
                else if (currentCommand[0] == "contains")
                {
                    Contains(currentCommand, inputList);
                }
                else if (currentCommand[0] == "remove")
                {
                    int index = int.Parse(currentCommand[1]);
                    inputList.RemoveAt(index);
                }
                else if (currentCommand[0] == "addMany")
                {
                    inputList = AddMany(currentCommand, inputList);
                }
                else if (currentCommand[0] == "sumPairs")
                {
                    inputList = SumPairs(inputList);
                }
                else if (currentCommand[0] == "shift")
                {
                    int positions = int.Parse(currentCommand[1]);
                    inputList = Shift(positions, inputList);
                }
            }
        }

        static void Contains(string[] currentCommand, List<int> inputList)
        {
            int element = int.Parse(currentCommand[1]);
            int index = -1;

            if (inputList.Contains(element))
            {
                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i] == element)
                    {
                        index = i;
                    }
                }
            }

            Console.WriteLine(index);
        }

        static List<int> AddMany(string[] currentCommand, List<int> inputList)
        {
            int index = int.Parse(currentCommand[1]);
            List<int> numbersInRange = new List<int>();

            for (int i = 2; i < currentCommand.Length; i++)
            {
                numbersInRange.Add(int.Parse(currentCommand[i]));
            }

            inputList.InsertRange(index, numbersInRange);
            return inputList;
        }

        static List<int> SumPairs(List<int> inputList)
        {
            List<int> newList = new List<int>();
            int index = 0;

            for (int i = 0; i < inputList.Count; i += 2)
            {
                if (i + 1 < inputList.Count)
                {
                    newList.Insert(index, inputList[i] + inputList[i + 1]);
                }

                index++;
            }
            inputList = newList;
            return inputList;
        }

        static List<int> Shift(int positions, List<int> inputList)
        {
            List<int> removedRange = new List<int>();

            for (int i = 0; i < positions; i++)
            {
                removedRange.Add(inputList[i]);
            }

            inputList.RemoveRange(0, positions);
            inputList.AddRange(removedRange);

            return inputList;
        }
    }
}
