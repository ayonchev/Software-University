using System;
using System.Collections.Generic;
using System.Linq;

namespace HitList
{
    class HitList
    {
        static void Main()
        {
            int targetIndex = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, string>> result = new Dictionary<string, Dictionary<string, string>>();

            while (true)
            {
                string[] currentData = Console.ReadLine()
                    .Split(new char[] { ':', '=', ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (currentData[0] != "end transmissions")
                {
                    string personName = currentData[0];

                    if (!result.ContainsKey(personName))
                    {
                        result.Add(personName, new Dictionary<string, string>());

                    }

                    for (int detail = 1; detail < currentData.Length; detail += 2)
                    {
                        string currentDetail = currentData[detail];
                        string currentDetailValue = currentData[detail + 1];

                        if (result[personName].ContainsKey(currentDetail))
                        {
                            result[personName][currentDetail] = currentDetailValue;
                        }
                        else
                        {
                            result[personName].Add(currentDetail, currentDetailValue);
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            string[] killCommand = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string personToKill = killCommand[1];
            int infoIndex = 0;

            Console.WriteLine($"Info on {personToKill}:");
            foreach (var detail in result[personToKill].OrderBy(x => x.Key))
            {
                Console.WriteLine($"---{detail.Key}: {detail.Value}");
                infoIndex += detail.Key.Length + detail.Value.Length;
            }
            Console.WriteLine($"Info index: {infoIndex}");

            if (infoIndex >= targetIndex)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                Console.WriteLine($"Need {Math.Abs(infoIndex-targetIndex)} more info.");
            }
        }
    }
}
