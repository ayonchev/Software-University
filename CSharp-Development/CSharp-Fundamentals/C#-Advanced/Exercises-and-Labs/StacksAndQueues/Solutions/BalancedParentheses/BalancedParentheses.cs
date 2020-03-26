using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string areBalanced = "YES";

            Stack<char> openingParentheses = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    openingParentheses.Push(input[i]);
                }
                else if ((input[i] == ')' || input[i] == '}' || input[i] == ']'))
                {
                    if (openingParentheses.Count == 0)
                    {
                        areBalanced = "NO";
                    }
                    else if ((input[i] == ')' && openingParentheses.Pop() != '(') || (input[i] == ']' && openingParentheses.Pop() != '[') || (input[i] == '}' && openingParentheses.Pop() != '{'))
                    {
                        areBalanced = "NO";
                    }
                }
            }

            Console.WriteLine(areBalanced);
        }
    }
}
