using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousCache
{
    class AnonymousCache
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string[] inputData = Console.ReadLine()
                    .Split(new char[] { ' ', '\t', '|', '-', '>' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (inputData[0] == "thetinggoesskrra")
                {
                    break;
                }
                else
                {
                    if (inputData.Length > 1)
                    {
                        string dataKey = inputData[0];
                        long dataSize = long.Parse(inputData[1]);
                        string dataSet = inputData[2];

                        if (data.ContainsKey(dataSet))
                        {
                            data[dataSet].Add(dataKey, dataSize);
                        }
                        else
                        {
                            if (cache.ContainsKey(dataSet))
                            {
                                cache[dataSet].Add(dataKey, dataSize);
                            }
                            else
                            {
                                Dictionary<string, long> currentData = new Dictionary<string, long>();
                                currentData.Add(dataKey, dataSize);
                                cache.Add(dataSet, currentData);
                            }
                        }
                    }
                    else
                    {
                        string dataSet = inputData[0];
                        if (!data.ContainsKey(dataSet))
                        {
                            if (cache.ContainsKey(dataSet))
                            {
                                data[dataSet] = cache[dataSet];
                            }
                            else
                            {
                                data.Add(dataSet, new Dictionary<string, long>());
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }

            foreach (var dataSet in data.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"Data Set: {dataSet.Key}, Total Size: {dataSet.Value.Values.Sum()}");
                foreach (var dataKey in dataSet.Value)
                {
                    Console.WriteLine($"$.{dataKey.Key}");
                }
                break;
            }
        }
    }
}
