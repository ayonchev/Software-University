using System;
using System.Collections.Generic;
using System.Text;

public class Pokemon
{
    private string name;
    private string type;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Type
    {
        get { return this.type; }
        set { this.type = value; }
    }

    public Pokemon(string currentName, string currentType)
    {
        this.name = currentName;
        this.type = currentType;
    }

    public override string ToString()
    {
        return $"{this.name} {this.type}\r\n";
    }
}
