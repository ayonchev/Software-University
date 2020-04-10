using System;
using System.Collections.Generic;

namespace LinkedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(string.Join(", ", stack.ToArray()));
        }
    }
}
