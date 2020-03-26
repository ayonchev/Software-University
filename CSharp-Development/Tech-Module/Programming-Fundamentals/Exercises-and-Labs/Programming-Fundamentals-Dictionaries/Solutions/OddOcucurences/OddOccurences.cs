using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOcucurences
{
    class OddOccurences
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().ToLower().Split(' ').ToArray();

            var resultDict = new Dictionary<string, int>();
            List<string> result = new List<string>();

            foreach (var item in inputArray)
            {
                if (resultDict.ContainsKey(item))
                {
                    resultDict[item]++;
                }
                else
                {
                    resultDict[item] = 1;
                }
            }

            foreach (var item in resultDict)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
