using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Sorter
{
    public static ICollection<T> Sort<T>(ICollection<T> elements)
        where T : IComparable
    {
        return elements.OrderBy(x => x).ToList();
    }
}
