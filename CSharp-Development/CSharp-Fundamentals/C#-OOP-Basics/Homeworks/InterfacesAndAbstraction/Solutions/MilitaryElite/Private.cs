using System;
using System.Collections.Generic;
using System.Text;

class Private : Soldier, IPrivate
{
    public Private(string id, string firstName, string lastName, double salary)
        : base(id, firstName, lastName)
    {
        this.Salary = salary;
    }
    public double Salary { get; set; }
}
