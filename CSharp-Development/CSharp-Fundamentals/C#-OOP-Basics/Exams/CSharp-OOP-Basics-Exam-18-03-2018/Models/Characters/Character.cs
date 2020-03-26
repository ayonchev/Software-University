using System;
using System.Collections.Generic;
using System.Text;

public abstract class Character
{
    // Change the access modifiers
    //Fix the health and armor
    private string name;
    private double baseHealth;
    private double health;
    private double baseArmor;
    private double armor;
    private double abilityPoints;
    private Bag bag;
    private readonly Faction faction;
    private bool isAlive;
    private double restHealMultiplier;

    public string Name
    {
        get { return name; }
        private set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be null or whitespace!");
            }
            name = value;
        }
    }

    public double BaseHealth
    {
        get { return baseHealth; }
        private set { baseHealth = value; }
    }

    public double Health
    {
        get { return health; }
        set
        {
            if (value < 0)
            {
                health = 0;
                IsAlive = false;
            }
            else if (value > BaseHealth)
            {
                health = BaseHealth;
            }
            else
            {
                health = value;
            }
        }
    }

    public double BaseArmor
    {
        get { return baseArmor; }
        private set { baseArmor = value; }
    }

    public double Armor
    {
        get { return armor; }
        set
        {
            if (value < 0)
            {
                armor = 0;
            }
            else if (value > BaseArmor)
            {
                armor = BaseArmor;
            }
            else
            {
                armor = value;
            }
        }
    }

    public double AbilityPoints
    {
        get { return abilityPoints; }
        private set { abilityPoints = value; }
    }

    public Bag Bag
    {
        get { return bag; }
        private set { bag = value; }
    }

    public Faction Faction
    {
        get { return faction; }
    }

    public bool IsAlive
    {
        get { return isAlive; }
        private set { isAlive = value; }
    }

    public double RestHealMultiplier
    {
        get { return restHealMultiplier; }
        protected set { restHealMultiplier = value; }
    }

    protected Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
    {
        this.Name = name;
        this.BaseHealth = health;
        this.Health = health;
        this.BaseArmor = armor;
        this.Armor = armor;
        this.AbilityPoints = abilityPoints;
        this.Bag = bag;
        this.faction = faction;
        this.IsAlive = true;
        this.RestHealMultiplier = 0.2;
    }

    public void TakeDamage(double hitPoints)
    {
        if (IsAlive)
        {
            double difference = Armor - hitPoints;
            Armor -= hitPoints;

            if (difference < 0)
            {
                Health += difference;
            }
        }
    }

    public void Rest()
    {
        if (IsAlive)
        {
            Health += (BaseHealth * RestHealMultiplier);
        }
    }

    public void UseItem(Item item)
    {
        if (IsAlive)
        {
            item.AffectCharacter(this);
        }
    }

    public void UseItemOn(Item item, Character character)
    {
        if (this.IsAlive && character.IsAlive)
        {
            item.AffectCharacter(character);
        }
    }

    public void GiveCharacterItem(Item item, Character character)
    {
        if (IsAlive && character.IsAlive)
        {
            character.ReceiveItem(item);
        }
    }

    public void ReceiveItem(Item item)
    {
        if (IsAlive)
        {
            this.Bag.AddItem(item);
        }
    }
}
