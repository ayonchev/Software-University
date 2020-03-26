using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendSeveralLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split('|').ToArray();

            List<int> result = new List<int>();

            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                List<int> currElement = inputArray[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                result.AddRange(currElement);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
