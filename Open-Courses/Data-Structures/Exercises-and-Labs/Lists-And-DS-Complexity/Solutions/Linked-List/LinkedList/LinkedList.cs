using LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;

public class LinkedList<T> : IEnumerable<T>
{
    public int Count { get; private set; }
    public Node<T> First { get; private set; }
    public Node<T> Last { get; private set; }

    public void AddFirst(T item)
    {
        Node<T> newFirstNode = new Node<T>(item);
        newFirstNode.Next = this.First;

        this.First = newFirstNode;
        if (Count == 0)
            Last = First;
        Count++;
    }

    public void AddLast(T item)
    {
        Node<T> oldLastNode = Last;
        Last = new Node<T>(item);

        if (Count == 0)
        {
            this.First = Last;
        }
        else
        {
            oldLastNode.Next = Last;
        }

        Count++;
    }

    public T RemoveFirst()
    {
        if (Count == 0)
            throw new InvalidOperationException();

        T removedNodeData = this.First.Data;
        this.First = First.Next;
        Count--;

        if (Count <= 1)
            Last = First;

        return removedNodeData;
    }

    public T RemoveLast()
    {
        if (Count == 0)
            throw new InvalidOperationException();

        T removedNodeData = this.Last.Data;

        if (Count == 1)
        {
            Last = null;
            First = Last;
        }
        else
        {
            Node<T> nodeBeforeLast = GetNodeBeforeLast();
            nodeBeforeLast.Next = null;
            this.Last = nodeBeforeLast;
        }
        
        Count--;

        return removedNodeData;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T> currentNode = First;
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

    private Node<T> GetNodeBeforeLast()
    {
        Node<T> currentNode = First;
        while (currentNode.Next != Last)
        {
            currentNode = currentNode.Next;
        }

        return currentNode;
    }
}
