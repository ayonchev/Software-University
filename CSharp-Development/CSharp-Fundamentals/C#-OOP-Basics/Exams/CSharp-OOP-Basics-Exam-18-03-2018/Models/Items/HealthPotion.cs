using System;
using System.Collections.Generic;
using System.Text;

public class HealthPotion : Item
{
    private const int defaultWeight = 5;
    public HealthPotion() : base(defaultWeight)
    {
    }

    public override void AffectCharacter(Character character)
    {
        base.AffectCharacter(character);
        character.Health += 20;
    }
}

