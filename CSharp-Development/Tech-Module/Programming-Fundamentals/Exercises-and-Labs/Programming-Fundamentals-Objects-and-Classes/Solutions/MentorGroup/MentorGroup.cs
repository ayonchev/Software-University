using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorGroup
{
    class MentorGroup
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Mentor> mentorsDict = new SortedDictionary<string, Mentor>();

            while (true)
            {
                string[] userAndDates = Console.ReadLine()
                    .Split(new char[] { ' ', ',' },
                    StringSplitOptions
                    .RemoveEmptyEntries);

                if (string.Join(" ", userAndDates) == "end of dates")
                {
                    break;
                }
                else
                {
                    string userName = userAndDates[0];

                    List<DateTime> currentUserDates = new List<DateTime>();
                    for (int i = 1; i < userAndDates.Length; i++)
                    {
                        currentUserDates.Add(DateTime.ParseExact(userAndDates[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }

                    if (!mentorsDict.ContainsKey(userName))
                    {
                        Mentor currentMentor = new Mentor()
                        {
                             Dates = currentUserDates,
                             Comments = new List<string>()
                        };
                        mentorsDict.Add(userName, currentMentor);
                    }
                    else
                    {
                        mentorsDict[userName].Dates.AddRange(currentUserDates);
                    }
                }
            }

            while (true)
            {
                string[] userAndComments = Console.ReadLine().Split('-');

                if (string.Join(" ", userAndComments) == "end of comments")
                {
                    break;
                }
                else
                {
                    string userName = userAndComments[0];

                    List<string> currentComments = new List<string>();
                    for (int i = 1; i < userAndComments.Length; i++)
                    {
                        currentComments.Add(userAndComments[i]);
                    }

                    if (mentorsDict.ContainsKey(userName))
                    {
                        mentorsDict[userName].Comments.AddRange(currentComments);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            foreach (var mentor in mentorsDict)
            {
                Console.WriteLine(mentor.Key);
                Console.WriteLine("Comments:");

                foreach (var comment in mentor.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in mentor.Value.Dates.OrderBy(x => x))
                {
                    string currDate = date.ToString("dd/MM/yyyy", CultureInfo.GetCultureInfo("en-US"));
                    Console.WriteLine($"-- {currDate}");
                }
            }
        }
    }
}
