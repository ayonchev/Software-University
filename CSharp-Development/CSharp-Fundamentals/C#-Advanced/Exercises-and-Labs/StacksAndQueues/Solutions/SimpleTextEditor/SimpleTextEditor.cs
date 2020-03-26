using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string currentString = String.Empty;
            Stack<string> previousVersion = new Stack<string>();

            previousVersion.Push(currentString);

            for (int i = 0; i < n; i++)
            {
                string[] currentCommand =
                    Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                switch (currentCommand[0])
                {
                    case "1":
                        currentString += currentCommand[1];
                        previousVersion.Push(currentString);
                        break;
                    case "2":
                        int length = int.Parse(currentCommand[1]);
                        currentString = currentString.Remove(currentString.Length - length, length);
                        previousVersion.Push(currentString);
                        break;
                    case "3":
                        int index = int.Parse(currentCommand[1]) - 1;
                        Console.WriteLine(currentString[index]);
                        break;
                    case "4":
                        previousVersion.Pop();
                        currentString = previousVersion.Peek();
                        break;
                }
            }
        }
    }
}
