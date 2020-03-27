using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split(new char[] { ' ', ',',';', '.', ':', '!', '[', ']', '\\', '/', '(', ')', '\"', '\'' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> upperCaseElements = new List<string>();
            List<string> lowerCaseElements = new List<string>();
            List<string> mixedCaseElements = new List<string>();

            foreach (var element in inputList)
            {
                bool upperCase = true;
                bool lowerCase = true;

                for (int i = 0; i < element.Length; i++)
                {
                    if (char.IsUpper(element[i]))
                    {
                        lowerCase = false;
                    }
                    else if (char.IsLower(element[i]))
                    {
                        upperCase = false;
                    }
                    else
                    {
                        upperCase = false;
                        lowerCase = false;
                    }
                }

                if (upperCase)
                {
                    upperCaseElements.Add(element);
                }
                else if (lowerCase)
                {
                    lowerCaseElements.Add(element);
                }
                else
                {
                    mixedCaseElements.Add(element);
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseElements));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseElements));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCaseElements));
        }
    }
}
