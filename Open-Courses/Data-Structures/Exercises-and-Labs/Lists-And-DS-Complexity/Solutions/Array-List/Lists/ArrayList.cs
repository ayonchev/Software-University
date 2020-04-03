using System;

public class ArrayList<T>
{

    private T[] data;
    public ArrayList()
    {
        Capacity = 2;
        data = new T[Capacity];
    }
    public int Count { get; set; }
    public int Capacity { get; private set; } 

    public T this[int index]
    {
        get
        {
            if (index < 0 || index > Count - 1)
                throw new ArgumentOutOfRangeException();

            return data[index];
        }

        set
        {
            if (index < 0 || index > Count - 1)
                throw new ArgumentOutOfRangeException();

            data[index] = value;
        }
    }

    public void Add(T item)
    {
        if (IsFull())
            Resize();

        data[++Count - 1] = item;
    }

    public T RemoveAt(int index)
    {
        T item = this[index];
        Shift(index);
        Count--;

        if (Count < Capacity / 4)
            Shrink();

        return item;
    }

    private bool IsFull() => this.Count == this.Capacity;

    private void Resize()
    {
        Capacity *= 2;
        T[] newArray = new T[Capacity];

        this.data = Copy(this.data, newArray, Count);
    }

    private void Shift(int index)
    {
        for (int i = index; i < Count; i++)
        {
            data[i] = data[i + 1];
        }
    }

    private void Shrink()
    {
        Capacity /= 4;
        T[] newArray = new T[Capacity];

        this.data = Copy(this.data, newArray, Count);
    }

    private T[] Copy(T[] sourceArray, T[] destinationArray, int count)
    {
        for (int i = 0; i < count; i++)
        {
            destinationArray[i] = data[i];
        }

        return destinationArray;
    }
}
