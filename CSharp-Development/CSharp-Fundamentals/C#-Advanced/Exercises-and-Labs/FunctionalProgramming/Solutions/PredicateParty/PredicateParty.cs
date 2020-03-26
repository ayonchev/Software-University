using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PredicateParty
{
    class PredicateParty
    {
        static void Main()
        {
            List<string> people = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, string, Func<string, bool>> filter =
                (startEndOrLength, letterOrLength) =>
                {
                    switch (startEndOrLength)
                    {
                        case "StartsWith":
                            return x => x.StartsWith(letterOrLength);
                        case "EndsWith":
                            return x => x.EndsWith(letterOrLength);
                        case "Length":
                            return x => x.Length == int.Parse(letterOrLength);
                    }
                    return null;
                };

            Action<string, string, string> modifyList = (removeOrDouble, startEndOrLength, letterOrLength) =>
            {
                if (removeOrDouble == "Remove")
                {
                    List<string> peopleToRemove = people.Where(filter(startEndOrLength, letterOrLength)).ToList();

                    foreach (var person in peopleToRemove)
                    {
                        people.Remove(person);
                    }
                }
                else
                {
                    List<string> peopleToDouble = people.Where(filter(startEndOrLength, letterOrLength)).ToList();

                    foreach (var person in peopleToDouble)
                    {
                        people.Add(person);
                    }
                }
            };



            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] != "Party!")
                {
                    string firstCriteria = command[0];
                    string secondCriteria = command[1];
                    string thirdCriteria = command[2];

                    modifyList(firstCriteria, secondCriteria, thirdCriteria);
                }
                else
                {
                    break;
                }
            }

            if (people.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine(string.Join(", ", people) + " are going to the party!");
            }
        }
    }
}
