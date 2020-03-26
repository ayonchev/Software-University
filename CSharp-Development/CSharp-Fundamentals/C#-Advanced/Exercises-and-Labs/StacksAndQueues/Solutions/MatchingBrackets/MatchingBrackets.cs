using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchingBrackets
{
    class MatchingBrackets
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            Stack<int> openingBrackets = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openingBrackets.Push(i);
                }
                else if (expression[i] == ')')
                {
                    Console.WriteLine(expression.Substring(openingBrackets.Peek(), i - openingBrackets.Pop() + 1));
                }
            }
        }
    }
}
