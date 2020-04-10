using System;

public class ArrayStack<T>
{
    private const int DefaultCapacity = 16;
    private T[] data;

    public ArrayStack(int capacity = DefaultCapacity)
    {
        this.data = new T[capacity];
    }
    public int Count { get; private set; }

    public T Peek()
    {
        return Count > 0 ? this.data[Count - 1] : throw new InvalidOperationException();
    }

    public void Push(T element)
    {
        if (Count == data.Length)
            Grow();

        this.data[Count++] = element;
    }

    public T Pop()
    {
        if (Count == 0)
            throw new InvalidOperationException();

        T topElement = this.data[--Count];

        return topElement;
    }

    public T[] ToArray()
    {
        T[] arrayCopy = new T[Count];
        int arrIndex = 0;
        for (int i = Count - 1; i >= 0; i--)
        {
            arrayCopy[arrIndex++] = this.data[i];
        }

        return arrayCopy;
    }

    private void Grow()
    {
        T[] newArray = new T[this.data.Length * 2];
        Array.Copy(this.data, 0, newArray, 0, this.data.Length);
        this.data = newArray;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ArrayStack<int> stack = new ArrayStack<int>();
        for (int i = 0; i < 17; i++)
        {
            stack.Push(i);
        }

        for (int i = 0; i < 17; i++)
        {
            Console.WriteLine(stack.Pop());
        }

        try
        {
            Console.WriteLine(stack.Pop());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
