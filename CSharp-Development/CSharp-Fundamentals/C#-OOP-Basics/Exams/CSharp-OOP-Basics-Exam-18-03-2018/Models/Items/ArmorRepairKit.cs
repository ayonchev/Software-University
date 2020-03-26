using System;
using System.Collections.Generic;
using System.Text;

public class ArmorRepairKit : Item
{
    private const int defaultWeight = 10;
    public ArmorRepairKit() : base(defaultWeight)
    {
    }

    public override void AffectCharacter(Character character)
    {
        base.AffectCharacter(character);
        character.Armor = character.BaseArmor;
    }
}
