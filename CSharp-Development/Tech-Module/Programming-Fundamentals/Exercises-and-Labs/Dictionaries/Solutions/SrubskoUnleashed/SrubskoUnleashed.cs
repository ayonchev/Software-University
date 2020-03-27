using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrubskoUnleashed
{
    class SrubskoUnleashed
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                List<string> inputList = Console.ReadLine().Split(' ').ToList();
                bool isValid = ValidInput(inputList);
                if (inputList[0] == "End")
                {
                    break;
                }
                else if (isValid == true)
                {
                    string singer = SingerAndVenue(inputList).First();
                    string venue = SingerAndVenue(inputList).Last();
                    long sum = SumOfTickets(inputList);

                    if (!result.ContainsKey(venue))
                    {
                        result.Add(venue, new Dictionary<string, long>());
                        result[venue].Add(singer, sum);
                    }
                    else
                    {
                        foreach (var venues in result)
                        {
                            Dictionary<string, long> singersDetails = venues.Value;
                            if (venues.Key == venue)
                            {
                                if (singersDetails.ContainsKey(singer))
                                {
                                    singersDetails[singer] += sum;
                                }
                                else
                                {
                                    singersDetails.Add(singer, sum);
                                }
                            }
                        }
                    }
                }
                else
                {
                    continue;
                }
            }

            foreach (var venue in result)
            {
                Dictionary<string, long> singers = venue.Value;
                Console.WriteLine(venue.Key);

                foreach (var singer in singers.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }

        static long SumOfTickets(List<string> inputList)
        {
            List<string> newList = new List<string>(inputList);
            long ticketCount = long.Parse(newList.Last());
            newList.RemoveAt(inputList.Count - 1);
            long ticketPrice = long.Parse(newList.Last());

            return ticketCount * ticketPrice;
        }

        static bool ValidInput(List<string> inputList)
        {
            List<string> newList = new List<string>(inputList);
            int ticketsCount;

            if (newList.Count > 3)
            {
                if (int.TryParse(newList.Last(), out ticketsCount))
                {
                    newList.RemoveAt(newList.Count - 1);
                    if (int.TryParse(newList.Last(), out ticketsCount))
                    {
                        for (int i = 0; i < newList.Count; i++)
                        {
                            string currentWord = newList[i];
                            if (currentWord.Contains("@") && currentWord[0] == '@')
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            
            return false;
        }

        static string[] SingerAndVenue(List<string> inputList)
        {
            string[] result = new string[2];
            string singer = "";
            string venue = "";

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i].Contains("@"))
                {
                    for (int j = 0; j < i; j++)
                    {
                        singer += inputList[j] + " ";
                    }
                    for (int k = i; k < inputList.Count - 2; k++)
                    {
                        venue += inputList[k] + " ";
                    }
                }
            }

            singer = singer.Substring(0, singer.Length - 1);
            venue = venue.Substring(1, venue.Length - 2);

            result[0] = singer;
            result[1] = venue;

            return result;
        }
    }
}
