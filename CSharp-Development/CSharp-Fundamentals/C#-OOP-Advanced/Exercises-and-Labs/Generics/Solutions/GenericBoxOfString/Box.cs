using System;
using System.Collections.Generic;
using System.Text;

public class Box<T>
    where T : IComparable
{
    public Box(T value)
    {
        this.Value = value;
    }
    public T Value { get; private set; }

    public bool CompareTo(T valueForComparison)
    {
        int comparison = this.Value.CompareTo(valueForComparison);

        if (comparison == 1)
            return true;
        else
            return false;
    }

    public override string ToString()
    {
        return $"{typeof(T).FullName}: {Value}";
    }
}
