using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;

public class Mission
{
    public Mission(string codeName, string state)
    {
        this.CodeName = codeName;
        this.State = state;
    }

    public string CodeName { get; set; }
    public string State { get; set; }

    public void CompleteMission()
    {
        this.State = "Finished";
    }
}
