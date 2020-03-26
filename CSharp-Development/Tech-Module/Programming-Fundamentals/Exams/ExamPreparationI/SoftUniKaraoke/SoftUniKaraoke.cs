using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKaraoke
{
    class SoftUniKaraoke
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                .Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);

            string[] availableSongs = Console.ReadLine()
                .Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);

            SortedDictionary<string, List<string>> result = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "dawn")
                {
                    break;
                }
                else
                {
                    string name = input[0].Trim();
                    string songName = input[1].Trim();
                    string award = input[2].Trim();

                    if (participants.Any(x => x.Trim() == name) && availableSongs.Any(x => x.Trim() == songName))
                    {
                        if (!result.ContainsKey(name))
                        {
                            result.Add(name, new List<string>());
                            result[name].Add(award);
                        }
                        else
                        {
                            if (result[name].Any(x => x == award))
                            {
                                continue;
                            }
                            else
                            {
                                result[name].Add(award);
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }


            if (result.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var participant in result.OrderByDescending(x => x.Value.Count))
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                    foreach (var award in participant.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
