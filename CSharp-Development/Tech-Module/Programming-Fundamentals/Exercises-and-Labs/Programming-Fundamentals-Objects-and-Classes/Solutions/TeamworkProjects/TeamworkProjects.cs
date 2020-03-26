using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Team> result = new Dictionary<string, Team>();

            for (int i = 0; i < count; i++)
            {
                string[] creatorsAndTeamsArray = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string creator = creatorsAndTeamsArray[0];
                string teamName = creatorsAndTeamsArray[1];

                if (!result.ContainsKey(creator))
                {
                    if (TeamExists(teamName, result))
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                    }
                    else
                    {
                        Team currentTeam = new Team()
                        {
                            Name = teamName,
                            Members = new List<string>()
                        };
                        result.Add(creator, currentTeam);

                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                }
                else
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
            }

            while (true)
            {
                string[] membersAndTeamArray = Console.ReadLine()
                    .Split(new char[] { '-', '>' }, 
                    StringSplitOptions
                    .RemoveEmptyEntries);

                

                if (string.Join(" ", membersAndTeamArray) == "end of assignment")
                {
                    break;
                }
                else
                {
                    string memberName = membersAndTeamArray[0];
                    string teamName = membersAndTeamArray[1];

                    if (TeamExists(teamName, result))
                    {
                        if (!MemberExists(memberName, result) && !result.ContainsKey(memberName))
                        {
                            string creatorsName = CreatorName(teamName, result);
                            result[creatorsName].Members.Add(memberName);
                        }
                        else if (MemberExists(memberName, result) || result.ContainsKey(memberName))
                        {
                            Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Team {teamName} does not exist!");
                    }
                }
            }

            foreach (var creator in result.OrderByDescending(x => x.Value.Members.Count))
            {
                if (creator.Value.Members.Count != 0)
                {
                    Console.WriteLine(creator.Value.Name);
                    Console.WriteLine("- " + creator.Key);
                    foreach (var member in creator.Value.Members.OrderBy(x => x))
                    {
                        Console.WriteLine("-- " + member);
                    }
                }
            }

            Console.WriteLine("Teams to disband: ");
            foreach (var creator in result)
            {
                if (creator.Value.Members.Count == 0)
                {
                    Console.WriteLine(creator.Value.Name);
                }
            }
        }

        static bool TeamExists(string teamName, Dictionary<string, Team> result)
        {
            foreach (var creator in result)
            {
                Team currentTeam = creator.Value;
                if (currentTeam.Name == teamName)
                {
                    return true;
                }
            }
            return false;
        }

        static bool MemberExists(string memberName, Dictionary<string, Team> result)
        {
            foreach (var creator in result)
            {
                Team currentTeam = creator.Value;
                if (currentTeam.Members.Contains(memberName))
                {
                    return true;
                }
            }
            return false;
        }

        static string CreatorName(string teamName, Dictionary<string, Team> result)
        {
            foreach (var creator in result)
            {
                Team currentTeam = creator.Value;
                if (currentTeam.Name == teamName)
                {
                    return creator.Key;
                }
            }
            return " ";
        }
    }
}
