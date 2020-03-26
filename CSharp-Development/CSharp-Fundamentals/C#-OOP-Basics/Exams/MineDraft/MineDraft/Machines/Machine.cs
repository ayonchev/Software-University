using System;
using System.Collections.Generic;
using System.Text;

public abstract class Machine
{
    public string Id { get; private set; }
    public abstract string Type { get; }

    protected Machine(string id)
    {
        this.Id = id;
    }
}
