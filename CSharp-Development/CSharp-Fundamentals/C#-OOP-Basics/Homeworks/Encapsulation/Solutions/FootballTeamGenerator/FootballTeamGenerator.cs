using System;
using System.Collections.Generic;
using System.Linq;

public class FootballTeamGenerator
{
    static void Main()
    {
        List<Team> teams = new List<Team>();

        BuildTeams(teams);
    }

    static void BuildTeams(List<Team> teams)
    {
        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            try
            {
                string[] currentData = input.Split(';');

                string command = currentData[0];
                string teamName = currentData[1];

                ExecuteCommand(command, teamName, teams, currentData);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    static void ExecuteCommand(string command, string teamName, List<Team> teams, string[] currentData)
    {
        Team currentTeam = new Team(teamName);

        switch (command)
        {
            case "Team":
                teams.Add(new Team(teamName));
                break;
            case "Add":
                Validator.ValidateTeamExistence(teamName, teams);
                currentTeam = teams.Find(t => t.Name == teamName);
                currentTeam.AddPlayer(new Player(currentData[2],
                    int.Parse(currentData[3]),
                    int.Parse(currentData[4]),
                    int.Parse(currentData[5]),
                    int.Parse(currentData[6]),
                    int.Parse(currentData[7])));
                break;
            case "Remove":
                Validator.ValidateTeamExistence(teamName, teams);
                currentTeam = teams.Find(t => t.Name == teamName);
                currentTeam.RemovePlayer(currentData[2]);
                break;
            case "Rating":
                Validator.ValidateTeamExistence(teamName, teams);
                Console.WriteLine($"{teamName} - {teams.Find(t => t.Name == teamName).Rating}");
                break;
        }
    }
}
