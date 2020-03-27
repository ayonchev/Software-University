using System;
using System.Collections.Generic;
using System.Text;

interface IResident
{
    string Name { get; }
    string Country { get; }
    string GetName();
}

