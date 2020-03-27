using System;
using System.Collections.Generic;
using System.Text;

public class Player
{
    private string name;
    private Stats stats;

    public Player(string playerName, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        this.Name = playerName;
        this.stats = new Stats(endurance, sprint, dribble, passing, shooting);
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

    public Stats Stats
    {
        get { return stats; }
        set { stats = value; }
    }
}
