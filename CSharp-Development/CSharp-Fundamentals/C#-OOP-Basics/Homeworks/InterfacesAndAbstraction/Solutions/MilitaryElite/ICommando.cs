using System;
using System.Collections.Generic;
using System.Text;

interface ICommando : ISpecialisedSoldier
{
    List<Mission> missions { get; set; }
}

