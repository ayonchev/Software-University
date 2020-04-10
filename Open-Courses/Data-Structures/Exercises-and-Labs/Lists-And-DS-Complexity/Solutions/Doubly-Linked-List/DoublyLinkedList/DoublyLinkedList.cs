using System;
using System.Collections;
using System.Collections.Generic;

public class DoublyLinkedList<T> : IEnumerable<T>
{
    public class Node
    {
        public Node(T data)
        {
            this.Data = data;
        }

        public T Data { get; set; }
        public Node Prev { get; set; }
        public Node Next { get; set; }
    }

    public Node First { get; private set; }
    public Node Last { get; private set; }
    public int Count { get; private set; }

    public void AddFirst(T element)
    {
        Node newFirstNode = new Node(element);
        Node oldFirstNode = First;
        newFirstNode.Next = oldFirstNode;
        First = newFirstNode;

        if(Count >= 1)
            oldFirstNode.Prev = First;
        else if (Count == 0)
        {
            Last = First;
        }

        Count++;
    }

    public void AddLast(T element)
    {
        Node newLastNode = new Node(element);
        Node oldLastNode = Last;
        newLastNode.Prev = oldLastNode;
        Last = newLastNode;

        if (Count >= 1)
            oldLastNode.Next = Last;
        if (Count == 0)
            First = Last;

        Count++;
    }

    public T RemoveFirst()
    {
        if (Count == 0)
            throw new InvalidOperationException();

        T oldFirstNodeData = First.Data;

        if(Count > 1)
        {
            First = First.Next;
            First.Prev = null;
        }
        else
        {
            First = Last = null;
        }

        Count--;

        return oldFirstNodeData;
    }

    public T RemoveLast()
    {
        if (Count == 0)
            throw new InvalidOperationException();

        T oldLastNodeData = Last.Data;

        if(Count > 1)
        {
            Last = Last.Prev;
            Last.Next = null;
        }
        else
        {
            First = Last = null;
        }

        Count--;

        return oldLastNodeData;
    }

    public void ForEach(Action<T> action)
    {
        foreach (var item in this)
        {
            action(item);
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node currentNode = First;
        while (currentNode != null)
        {
            yield return currentNode.Data;
            currentNode = currentNode.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public T[] ToArray()
    {
        T[] array = new T[Count];
        int index = 0;

        foreach (var item in this)
        {
            array[index++] = item;
        }

        return array;
    }
}


class Example
{
    static void Main()
    {
        var list = new DoublyLinkedList<int>();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.AddLast(5);
        list.AddFirst(3);
        list.AddFirst(2);
        list.AddLast(10);
        Console.WriteLine("Count = {0}", list.Count);

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.RemoveFirst();
        list.RemoveLast();
        list.RemoveFirst();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.RemoveLast();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");
    }
}
