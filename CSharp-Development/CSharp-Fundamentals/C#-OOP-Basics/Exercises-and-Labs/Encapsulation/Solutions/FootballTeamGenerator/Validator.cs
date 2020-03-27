using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Validator
{
    private const int MIN_VALUE = 0;
    private const int MAX_VALUE = 100;
    public static void ValidateName(string name)
    {
        if (name.Trim() == String.Empty || name == null)
        {
            throw new ArgumentException("A name should not be empty.");
        }
    }

    public static void ValidateStat(string statName, int statValue)
    {
        if (statValue < MIN_VALUE || statValue > MAX_VALUE)
        {
            throw new ArgumentException($"{statName} should be between 0 and 100.");
        }
    }

    public static void ValidateTeamExistence(string teamName, List<Team> teams)
    {
        if (!teams.Any(t => t.Name == teamName))
        {
            throw new ArgumentException($"Team {teamName} does not exist.");
        }
    }
}
