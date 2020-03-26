using System;
using System.Collections.Generic;
using System.Text;

public class PersonAgeComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        return x.Age.CompareTo(y.Age);
    }
}
