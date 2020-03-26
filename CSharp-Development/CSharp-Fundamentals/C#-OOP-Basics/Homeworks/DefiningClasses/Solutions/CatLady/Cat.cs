using System;
using System.Collections.Generic;
using System.Text;

public class Cat
{
    private string name;
    private string breed;
    private double physicalCharacteristics;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public string Breed
    {
        get { return this.breed; }
        set { this.breed = value; }
    }

    public double PhisycalCharacteristics
    {
        get { return this.physicalCharacteristics; }
        set { this.physicalCharacteristics = value; }
    }

    public Cat(string currentBreed, string currentName, double currentPhysicalCharacteristics)
    {
        this.breed = currentBreed;
        this.name = currentName;
        this.physicalCharacteristics = currentPhysicalCharacteristics;
    }

    public override string ToString()
    {
        if (this.breed == "Cymric")
        {
            return $"{this.breed} {this.name} {this.physicalCharacteristics:F2}";
        }
        return $"{this.breed} {this.name} {this.physicalCharacteristics}";
    }
}
