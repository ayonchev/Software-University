using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Person
{
    private string name;
    private Company company;
    private Car car;
    private List<Pokemon> pokemons;
    private List<Parent> parents;
    private List<Child> children;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public Company Company
    {
        get { return this.company; }
        set { this.company = value; }
    }
    public Car Car
    {
        get { return this.car; }
        set { this.car = value; }
    }
    public List<Pokemon> Pokemons
    {
        get { return this.pokemons; }
        set { this.pokemons = value; }
    }
    public List<Parent> Parents
    {
        get { return this.parents; }
        set { this.parents = value; }
    }
    public List<Child> Children
    {
        get { return this.children; }
        set { this.children = value; }
    }

    public Person(string currentName)
    {
        this.name = currentName;
        this.company = new Company();
        this.car = new Car();
        this.pokemons = new List<Pokemon>();
        this.parents = new List<Parent>();
        this.children = new List<Child>();
    }

    public override string ToString()
    {
        string result = $"{this.name}\r\n" +
                        $"Company:\r\n" +
                        $"{this.company.ToString()}" +
                        $"Car:\r\n" +
                        $"{this.car.ToString()}" +
                        $"Pokemon:\r\n" +
                        $"{string.Join("", this.pokemons.Select(p => p.ToString()))}" +
                        $"Parents:\r\n" +
                        $"{string.Join("", this.parents.Select(p => p.ToString()))}" +
                        $"Children:\r\n" +
                        $"{string.Join("", this.children.Select(p => p.ToString()))}";
        return result;
    }
}
