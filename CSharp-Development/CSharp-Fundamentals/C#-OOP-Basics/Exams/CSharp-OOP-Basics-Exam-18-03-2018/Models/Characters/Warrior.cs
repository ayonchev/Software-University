using System;
using System.Collections.Generic;
using System.Text;

public class Warrior : Character, IAttackable
{
    private const double defaultBaseHealth = 100;
    private const double defaultBaseArmor = 50;
    private const double defaultAbilityPoints = 40;
    public Warrior(string name, Faction faction) : base(name, defaultBaseHealth, defaultBaseArmor, defaultAbilityPoints, new Satchel(), faction)
    {
    }

    public void Attack(Character character)
    {
        if (IsAlive && character.IsAlive)
        {
            if (character == this)
            {
                throw new InvalidOperationException("Cannot attack self!");
            }

            if (Faction == character.Faction)
            {
                throw new ArgumentException($"Friendly fire! Both characters are from {character.Faction} faction!");
            }

            character.TakeDamage(this.AbilityPoints);
        }
    }
}

