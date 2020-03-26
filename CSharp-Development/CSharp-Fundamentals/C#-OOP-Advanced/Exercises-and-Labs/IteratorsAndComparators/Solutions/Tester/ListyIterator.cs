using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ListyIterator<T> : IEnumerable<T>
{
    private List<T> data;
    private int currentIndex = 0;

    public ListyIterator(params T[] collection)
    {
        this.data = new List<T>(collection);
    }

    public bool Move()
    {
        if (HasNext())
        {
            currentIndex++;
            return true;
        }

        return false;
    }

    public bool HasNext()
    {
        if (currentIndex + 1 >= data.Count)
        {
            return false;
        }

        return true;
    }

    public T Print()
    {
        if (this.data.Count == 0 || this.currentIndex >= data.Count)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }

        return data[currentIndex];
    }

    public string PrintAll()
    {
        if (this.data.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }

        string result = string.Empty;

        foreach (var element in data)
        {
            result += element + " ";
        }

        return result.TrimEnd();
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int index = 0; index < this.data.Count; index++)
        {
            yield return data[index];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
