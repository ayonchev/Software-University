using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();

                if ((command[0] == "Even" || command[0] == "Odd") && command.Length == 1)
                {
                    OddOrEvenNumbersInRange(command[0], inputList);
                    break;
                }
                else if (command.Length == 3)
                {
                    inputList.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                else if (command.Length == 2)
                {
                    inputList.RemoveAll(item => item == int.Parse(command[1]));
                }
            }
        }

        static void OddOrEvenNumbersInRange(string typeOfNumbers, List<int> inputList)
        {
            if (typeOfNumbers == "Even")
            {
                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i] % 2 == 0)
                    {
                        Console.Write(inputList[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (typeOfNumbers == "Odd")
            {
                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i] % 2 != 0)
                    {
                        Console.Write(inputList[i] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
