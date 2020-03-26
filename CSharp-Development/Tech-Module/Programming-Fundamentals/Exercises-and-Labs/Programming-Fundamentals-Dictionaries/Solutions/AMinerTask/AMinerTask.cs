using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            var resultDict = new Dictionary<string, long>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }
                else
                {
                    long quantity = long.Parse(Console.ReadLine());
                    if (resultDict.ContainsKey(input))
                    {
                        resultDict[input] += quantity;
                    }
                    else
                    {
                        resultDict.Add(input, quantity);
                    }
                }
            }

            foreach (var material in resultDict)
            {
                Console.WriteLine(material.Key + " -> " + material.Value);
            }
        }
    }
}
