using System;
using System.Linq;
using System.Security.Claims;

public class Program
{
    static void Main()
    {
        var myStack = new CustomStack<int>();

        try
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] commandArgs = input.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArgs[0];

                switch (commandType)
                {
                    case "Push":
                        int[] args = commandArgs.Skip(1).Select(int.Parse).ToArray();
                        myStack.Push(args);
                        break;
                    case "Pop":
                        myStack.Pop();
                        break;
                }
            }

            myStack.Print();
            myStack.Print();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

