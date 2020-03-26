using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Stack<int> result = new Stack<int>();
            Stack<int> maxStack = new Stack<int>();
            maxStack.Push(0);

            for (int i = 0; i < numberOfLines; i++)
            {
                int[] currentQuery = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                int command = currentQuery[0];

                if (command == 1)
                {
                    int currentNumber = currentQuery[1];
                    
                    result.Push(currentQuery[1]);

                    if (result.Peek() > maxStack.Peek())
                    {
                        maxStack.Push(currentNumber);
                    }
                }
                else if (command == 2)
                {
                    if (maxStack.Contains(result.Peek()))
                    {
                        maxStack.Pop();
                    }

                    result.Pop();
                }
                else
                {
                    Console.WriteLine(maxStack.Peek());
                }
            }
        }
    }
}
