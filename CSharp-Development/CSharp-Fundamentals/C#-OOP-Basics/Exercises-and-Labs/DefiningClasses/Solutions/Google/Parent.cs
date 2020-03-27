using System;
using System.Collections.Generic;
using System.Text;

public class Parent
{
    private string name;
    private string birthday;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Birthday
    {
        get { return this.birthday; }
        set { this.birthday = value; }
    }

    public Parent(string currentName, string birthday)
    {
        this.name = currentName;
        this.birthday = birthday;
    }

    public override string ToString()
    {
        return $"{this.name} {this.birthday}\r\n";
    }
}
