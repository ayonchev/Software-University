using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var resultDict = new SortedDictionary<string, SortedDictionary<string, long>>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                string ip = input[0];
                string user = input[1];
                long duration = long.Parse(input[2]);

                if (!resultDict.ContainsKey(user))
                {
                    resultDict.Add(user, new SortedDictionary<string, long>());
                    resultDict[user].Add(ip, duration);
                }
                else
                {
                    foreach (var person in resultDict)
                    {
                        SortedDictionary<string, long> userData = person.Value;
                        if (person.Key == user)
                        {
                            if (userData.ContainsKey(ip))
                            {
                                userData[ip] += duration;
                            }
                            else
                            {
                                userData.Add(ip, duration);
                            }
                        }
                    }
                }
            }

            foreach (var user in resultDict)
            {
                Console.WriteLine(user.Key + ": " + user.Value.Values.Sum() + " [" + string.Join(", ",user.Value.Keys) + "]");
            }
        }
    }
}
