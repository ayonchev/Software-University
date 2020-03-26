using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Stacks
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Replace(" ", String.Empty);

            string numberPattern = @"(?:\-|\+)?\d+";

            Stack<int> resultNums = new Stack<int>();
            
            int result = 0;

            foreach (Match number in Regex.Matches(input, numberPattern))
            {
                resultNums.Push(int.Parse(number.ToString()));
            }

            while (resultNums.Count > 0)
            {
                result += resultNums.Pop();
            }

            Console.WriteLine(result);
        }
    }
}
