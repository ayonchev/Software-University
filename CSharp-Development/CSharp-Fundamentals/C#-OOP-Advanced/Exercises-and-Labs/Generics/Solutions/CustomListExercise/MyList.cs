using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class MyList<T>
    where T : IComparable<T>
{
    private T[] elements;
    private int capacity;
    private int currentIndex;
    public MyList()
    {
        this.elements = new T[4];
        this.capacity = 4;
        this.currentIndex = 0;
    }

    public void Add(T element)
    {
        if (currentIndex == elements.Length)
        {
            IncreaseCapacity();
        }

        elements[currentIndex] = element;
        currentIndex++;
    }

    public T Remove(int index)
    {
        var removedElement = elements[index];

        T[] newElements = new T[elements.Length - 1];
        int newArrCurrIndex = 0;

        for (int arrIndex = 0; arrIndex < elements.Length; arrIndex++)
        {
            if (arrIndex != index)
            {
                newElements[newArrCurrIndex] = elements[arrIndex];
                newArrCurrIndex++;
            }
        }

        this.elements = newElements;
        this.currentIndex = elements.Length;

        return removedElement;
    }

    public bool Contains(T element)
    {
        for (int index = 0; index < elements.Length; index++)
        {
            if (elements[index].Equals(element))
            {
                return true;
            }
        }

        return false;
    }

    public void Swap(int firstIndex, int secondIndex)
    {
        var temp = elements[firstIndex];
        elements[firstIndex] = elements[secondIndex];
        elements[secondIndex] = temp;
    }
    public int CountGreaterThan(T element)
    {
        int greaterElements = 0;

        foreach (var currentElement in elements)
        {
            if (CompareTo(currentElement, element))
                greaterElements++;
        }

        return greaterElements;
    }

    public T Max()
    {
        T maxElement = default(T);

        for (int index = 1; index < elements.Length; index++)
        {
            int comparison = elements[index].CompareTo(elements[index - 1]);
            if (comparison > 0)
            {
                if (elements[index].CompareTo(maxElement) > 0)
                {
                    maxElement = elements[index];
                }
            }
            else if (comparison < 0)
            {
                if (elements[index - 1].CompareTo(maxElement) > 0)
                {
                    maxElement = elements[index - 1];
                }
            }
        }

        return maxElement;
    }

    public T Min()
    {
        T minElement = default(T);

        for (int index = 1; index < elements.Length; index++)
        {
            int comparison = elements[index].CompareTo(elements[index - 1]);
            if (comparison < 0)
            {
                if (elements[index].CompareTo(minElement) < 0)
                {
                    minElement = elements[index];
                }
            }
            else if (comparison > 0)
            {
                if (elements[index - 1].CompareTo(minElement) < 0)
                {
                    minElement = elements[index - 1];
                }
            }
        }

        return minElement;
    }

    public void Print()
    {
        foreach (var element in elements)
        {
            if (!EqualityComparer<T>.Default.Equals(element, default(T)))
            {
                Console.WriteLine(element);
            }
        }
    }

    public void Sort()
    {
        //elements = Sorter.Sort(elements).ToList();
    }

    private bool CompareTo(T currentValue, T valueForComparison)
    {
        int comparison = currentValue.CompareTo(valueForComparison);

        if (comparison == 1)
            return true;
        else
            return false;
    }

    private void IncreaseCapacity()
    {
        this.capacity += 4;
        T[] newElements = new T[capacity];
        elements.CopyTo(newElements, 0);

        this.elements = newElements;
    }
}
