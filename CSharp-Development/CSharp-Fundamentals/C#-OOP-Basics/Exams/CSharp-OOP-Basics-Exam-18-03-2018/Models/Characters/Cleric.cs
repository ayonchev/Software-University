using System;
using System.Collections.Generic;
using System.Text;

public class Cleric : Character, IHealable
{
    private const double defaultBaseHealth = 50;
    private const double defaultBaseArmor = 25;
    private const double defaultAbilityPoints = 40;

    public Cleric(string name, Faction faction) : base(name, defaultBaseHealth, defaultBaseArmor, defaultAbilityPoints, new Backpack(), faction)
    {
        base.RestHealMultiplier = 0.5;
    }

    public void Heal(Character character)
    {
        if (IsAlive && character.IsAlive)
        {
            if (this.Faction != character.Faction)
            {
                throw new InvalidOperationException($"Cannot heal enemy character!");
            }

            character.Health += this.AbilityPoints;
        }
    }
}
