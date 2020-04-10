using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LinkedQueue<T>
{
    public class QueueNode<T>
    {
        public QueueNode(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public QueueNode<T> Prev { get; set; }
        public QueueNode<T> Next { get; set; }
    }

    public QueueNode<T> Head { get; private set; }
    public QueueNode<T> Tail { get; private set; }
    public int Count { get; private set; }
    public int MyProperty { get; set; }

    public void Enqueue(T data)
    {
        QueueNode<T> newTail = new QueueNode<T>(data);
        QueueNode<T> oldTail = Tail;

        newTail.Prev = this.Tail;
        Tail = newTail;

        if (Count >= 1)
            oldTail.Next = newTail;
        else
            Head = Tail;

        Count++;
    }

    public T Dequeue()
    {
        if (Count == 0)
            throw new InvalidOperationException();

        T firstElement = Head.Data;
        if (Count > 1)
        {
            Head = Head.Next;
            Head.Prev = null;
        }
        else
        {
            Head = Tail = null;
        }
        Count--;

        return firstElement;
    }

    public T[] ToArray()
    {
        T[] array = new T[Count];
        int index = 0;

        QueueNode<T> currentNode = Head;
        while (currentNode != null)
        {
            array[index++] = currentNode.Data;
            currentNode = currentNode.Next;
        }

        return array;
    }
}

public class Program
{
    public static void Main(string[] args)
    {

    }
}
