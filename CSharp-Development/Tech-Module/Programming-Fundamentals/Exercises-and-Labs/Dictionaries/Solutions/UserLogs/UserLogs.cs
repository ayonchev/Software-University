using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            var resultDict = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                List<string> input = Console.ReadLine().Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (input[0] == "end")
                {
                    break;
                }
                else
                {
                    input.Remove("IP");
                    input.Remove("message");
                    input.Remove("user");

                    string user = input[2];
                    string ip = input[0];

                    if (!resultDict.ContainsKey(user))
                    {
                        resultDict.Add(user, new Dictionary<string, int>());
                        resultDict[user].Add(ip, 1);
                    }
                    else
                    {
                        foreach (var person in resultDict)
                        {
                            Dictionary<string, int> details = person.Value;
                            if (person.Key == user)
                            {
                                if (details.ContainsKey(ip))
                                {
                                    details[ip]++;
                                }
                                else
                                {
                                    details[ip] = 1;
                                }
                            }
                        }
                    }
                }
            }

            foreach (var user in resultDict)
            {
                Dictionary<string, int> currentDetails = user.Value;
                Console.WriteLine(user.Key + ": ");

                foreach (var detailsOfUser in currentDetails)
                {
                    var lastUser = currentDetails.Last();
                    if (!detailsOfUser.Equals(lastUser))
                    {
                        Console.Write(detailsOfUser.Key + " => " + detailsOfUser.Value + ", ");
                    }
                    else
                    {
                        Console.Write(detailsOfUser.Key + " => " + detailsOfUser.Value + ".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
