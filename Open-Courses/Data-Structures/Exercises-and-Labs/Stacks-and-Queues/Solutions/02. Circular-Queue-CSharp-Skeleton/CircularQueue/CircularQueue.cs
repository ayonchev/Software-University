using System;
using System.Collections;
using System.Collections.Generic;

public class CircularQueue<T>
{
    private const int DefaultCapacity = 4;
    private T[] data;
    private int head;
    private int tail;

    public int Count { get; private set; }

    public CircularQueue(int capacity = DefaultCapacity)
    {
        this.data = new T[capacity];
        this.head = this.tail = 0;
        Count = 0;
    }

    public void Enqueue(T element)
    {
        if (Count == this.data.Length)
        {
            Resize();
        }

        data[this.tail] = element;
        this.Count++;
        this.tail = (this.tail + 1) % this.data.Length;
    }

    private void Resize()
    {
        T[] newArray = new T[this.data.Length * 2];
        CopyAllElements(newArray);
        this.data = newArray;
        this.head = 0;
        this.tail = Count;
    }

    private void CopyAllElements(T[] newArray)
    {
        int arrIndex = 0;
        int queueIndex = head;

        while (arrIndex < Count)
        {
            newArray[arrIndex++] = data[queueIndex];
            queueIndex = (queueIndex + 1) % this.data.Length;
        }
    }

    // Should throw InvalidOperationException if the queue is empty
    public T Dequeue()
    {
        if (Count == 0)
            throw new InvalidOperationException();

        T item = this.data[head];
        this.data[head] = default(T);
        this.head = (this.head + 1) % this.data.Length;
        this.Count--;

        return item;
    }

    public T[] ToArray()
    {
        T[] array = new T[Count];
        CopyAllElements(array);

        return array;
    }
}

public class Example
{
    public static void Main()
    {
        CircularQueue<int> queue = new CircularQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Dequeue();
        queue.Enqueue(5);
        queue.Enqueue(6);
        queue.Enqueue(7);
        queue.Enqueue(8);
        queue.Dequeue();
        queue.Dequeue();
        queue.Enqueue(9);
        queue.Enqueue(10);
        queue.Enqueue(11);
        queue.Enqueue(12);
        queue.Enqueue(13);

        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        int first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-7);
        queue.Enqueue(-8);
        queue.Enqueue(-9);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-10);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");
    }
}
