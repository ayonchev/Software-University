using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Team
{
    private string name;
    private int rating;
    private List<Player> players;

    public Team(string teamName)
    {
        this.Name = teamName;
        this.players = new List<Player>();
        this.Rating = 0;
    }

    public string Name
    {
        get { return name; }
        set
        {
            Validator.ValidateName(value);
            name = value;
        }
    }

    public int Rating
    {
        get
        {
            if (players.Count == 0)
            {
                this.rating = 0;
            }
            else
            {
                this.rating = (int)Math.Round(this.players.Average(p => p.Stats.SkillLevel));
            }

            return this.rating;
        }
        private set { rating = value; }
    }

    public void RemovePlayer(string playerName)
    {
        if (!this.players.Any(p => p.Name == playerName))
        {
            Console.WriteLine($"Player {playerName} is not in {this.name} team.");
        }
        else
        {
            Player currentPlayer = players.Find(p => p.Name == playerName);
            this.players.Remove(currentPlayer);
        }
    }

    public void AddPlayer(Player currentPlayer)
    {
        players.Add(currentPlayer);
    }
}
