using System;
using System.Collections.Generic;
using System.Text;

public class CharacterFactory
{
    public Character CreateCharacter(string faction, string characterType, string name)
    {
        Faction currentFaction;
        if (!Faction.TryParse(faction, out currentFaction))
        {
            throw new ArgumentException($"Invalid faction \"{faction}\"!");
        }

        switch (characterType)
        {
            case "Cleric":
                return new Cleric(name, currentFaction);
            case "Warrior":
                return new Warrior(name, currentFaction);
            default:
                throw new ArgumentException($"Invalid character type \"{ characterType }\"!");
        }
    }
}

