using System;
using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    public LeutenantGeneral(string id, string firstName, string lastName, double salary)
        : base(id, firstName, lastName, salary)
    {
        
    }

    public List<Private> privates { get; set; }
}
