using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RoliTheCoder
{
    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            Dictionary<string, Event> result = new Dictionary<string, Event>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ', '\t' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (string.Join(" ", input) == "Time for Code")
                {
                    break;
                }
                else
                {
                    bool isValid = IsValidInput(input);

                    if (isValid)
                    {
                        string id = input[0];
                        string eventName = input[1].Substring(1, input[1].Length - 1);

                        if (!result.ContainsKey(id))
                        {
                            List<string> currentParticipants = new List<string>();

                            for (int i = 2; i < input.Length; i++)
                            {
                                //if (!currentParticipants.Contains(input[i]))
                                //{
                                    currentParticipants.Add(input[i]);
                                //}
                            }

                            currentParticipants = currentParticipants.Distinct().ToList();

                            Event currentEvent = new Event()
                            {
                                Name = eventName,
                                Participants = currentParticipants
                            };

                            result.Add(id, currentEvent);
                        }
                        else
                        {
                            if (result[id].Name == eventName)
                            {
                                for (int i = 2; i < input.Length; i++)
                                {
                                    if (!result[id].Participants.Any(x => x == input[i]))
                                    {
                                        result[id].Participants.Add(input[i]);
                                    }
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            foreach (var currEvent in result.OrderByDescending(x => x.Value.Participants.Count).ThenBy(x => x.Value.Name))
            {
                Console.WriteLine(currEvent.Value.Name + " - " + currEvent.Value.Participants.Count);
                foreach (var participant in currEvent.Value.Participants.OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }

        static bool IsValidInput(string[] input)
        {
            if (!Regex.IsMatch(input[0], @"^\d+$"))
            {
                return false;
            }

            if (!Regex.IsMatch(input[1], @"^\#\w+$"))
            {
                return false;
            }

            for (int i = 2; i < input.Length; i++)
            {
                if (input[i].First() != '@')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
