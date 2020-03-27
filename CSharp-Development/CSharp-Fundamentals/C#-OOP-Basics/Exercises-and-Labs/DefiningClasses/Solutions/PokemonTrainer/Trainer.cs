using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Trainer
{
    private string name;
    private int numberOfBadges;
    private List<Pokemon> pokemons;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int NumberOfBadges
    {
        get { return this.numberOfBadges; }
        set { this.numberOfBadges = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return this.pokemons; }
        set { this.pokemons = value; }
    }

    public Trainer(string name, Pokemon currentPokemon)
    {
        this.name = name;
        this.pokemons = new List<Pokemon>();
        this.pokemons.Add(currentPokemon);
        this.numberOfBadges = 0;
    }

    public void CheckForElement(string element)
    {
        if (this.pokemons.Any(p => p.Element == element))
        {
            this.numberOfBadges++;
        }
        else
        {
            this.pokemons.ForEach(p => p.Health -= 10);
        }

        this.pokemons.RemoveAll(p => p.Health <= 0);
    }
}
