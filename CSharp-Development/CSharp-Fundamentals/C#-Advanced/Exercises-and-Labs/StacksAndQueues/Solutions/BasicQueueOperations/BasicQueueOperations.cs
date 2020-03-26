using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            int[] modifyNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numbersToPush = modifyNumbers[0];
            int numbersToPop = modifyNumbers[1];
            int numberToFind = modifyNumbers[2];

            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> result = new Queue<int>();

            for (int i = 0; i < numbersToPush; i++)
            {
                result.Enqueue(numbers[i]);
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                result.Dequeue();
            }

            if (result.Contains(numberToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (result.Count > 0)
                {
                    Console.WriteLine(result.OrderBy(x => x).First());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
