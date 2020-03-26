using System;
using System.Collections.Generic;
using System.Text;

public abstract class Item
{
    public int Weight { get; private set; }
    public string Name => this.GetType().Name;

    protected Item(int weight)
    {
        this.Weight = weight;
    }

    public virtual void AffectCharacter(Character character)
    {
        if (!character.IsAlive)
        {
            throw new InvalidOperationException("Must be alive to perform this action!");
        }
    }
}

