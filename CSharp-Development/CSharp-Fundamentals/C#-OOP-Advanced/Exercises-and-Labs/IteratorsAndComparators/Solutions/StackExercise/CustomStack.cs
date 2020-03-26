using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CustomStack<T> : IEnumerable<T>
{
    private List<T> collection;

    public CustomStack()
    {
        this.collection = new List<T>();
    }

    public void Push(params T[] elements)
    {
        this.collection.AddRange(elements);
    }

    public void Pop()
    {
        CheckIfEmpty();

        this.collection.RemoveAt(this.collection.Count - 1);
    }

    public void Print()
    {
        foreach (var element in this)
        {
            Console.WriteLine(element);
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int index = this.collection.Count - 1; index >= 0; index--)
        {
            yield return collection[index];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    private void CheckIfEmpty()
    {
        if (this.collection.Count == 0)
        {
            throw new ArgumentException("No elements");
        }
    }
}
