using System;
using System.Collections.Generic;
using System.Text;

interface IEngineer : ISpecialisedSoldier
{
    List<Repair> repairs { get; set; }
}
