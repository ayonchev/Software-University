using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyReservationFilterModule
{
    class PartyReservationFilterModule
    {
        static void Main()
        {
            List<string> people = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> filters = new List<string>();


            while (true)
            {
                string[] currentCommand = Console.ReadLine()
                    .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (currentCommand[0] != "Print")
                {
                    string addOrRemoveFilter = currentCommand[0];
                    string currentPersonFilter = currentCommand[1];
                    string startStringOrLength = currentCommand[2];

                    string currentFilter = currentCommand[1] + "," + currentCommand[2];

                    if (addOrRemoveFilter == "Add filter")
                    {
                        filters.Add(currentFilter);
                    }
                    else
                    {
                        filters.Remove(currentFilter);
                    }
                }
                else
                {
                    break;
                }
            }

            foreach (var filter in filters)
            {
                string[] filterArguments = filter.Split(',');
                var currentFilter = GetFilters(filterArguments[0], filterArguments[1]);

                people = people.Where(currentFilter).ToList();
            }

            Console.WriteLine(string.Join(" ", people));
        }

        static Func<string, bool> GetFilters(string personFilter, string startStringOrLength)
        {
            switch (personFilter)
            {
                case "Starts with":
                    return x => !x.StartsWith(startStringOrLength);
                case "Ends with":
                    return x => !x.EndsWith(startStringOrLength);
                case "Contains":
                    return x => !x.Contains(startStringOrLength);
                case "Length":
                    return x => x.Length != int.Parse(startStringOrLength);
            }
            return null;
        }
    }
}
