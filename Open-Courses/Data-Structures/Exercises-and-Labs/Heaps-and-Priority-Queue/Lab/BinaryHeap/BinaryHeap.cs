using System;
using System.Collections.Generic;

public class BinaryHeap<T> where T : IComparable<T>
{
    private List<T> heap;

    public BinaryHeap()
    {
        heap = new List<T>();
    }

    public int Count => heap.Count;

    public void Insert(T item)
    {
        heap.Add(item);
        HeapifyUp(heap.Count - 1);
    }

    public T Peek()
    {
        return heap[0];
    }

    public T Pull()
    {
        if (Count == 0)
            throw new InvalidOperationException();

        var lastRootElement = heap[0];

        Swap(0, heap.Count - 1);
        heap.RemoveAt(heap.Count - 1);

        HeapifyDown(0);

        return lastRootElement;
    }

    private void HeapifyUp(int index)
    {
        if (index <= 0) 
            return;

        var parentIndex = (index - 1) / 2;
        var parentElement = heap[parentIndex];
        var currentElement = heap[index];
        
        if (currentElement.CompareTo(parentElement) > 0)
        {
            Swap(parentIndex, index);
            HeapifyUp(parentIndex);
        }
    }

    private void HeapifyDown(int index)
    {
        for (
            int parentIndex = index, childIndex = GetChildIndex(parentIndex); 
            parentIndex < Count / 2; 
            parentIndex = GetChildIndex(parentIndex), childIndex = GetChildIndex(parentIndex))
        {
            var parent = heap[parentIndex];
            var child = GetBiggerChild(childIndex, childIndex + 1);

            if (child?.Item1?.CompareTo(parent) > 0)
            {
                Swap(child.Item2, parentIndex);
            }
        }
    }

    private void Swap(int firstIndex, int secondIndex)
    {
        T firstElement = heap[firstIndex];

        heap[firstIndex] = heap[secondIndex];
        heap[secondIndex] = firstElement;
    }

    private Tuple<T, int> GetBiggerChild(int leftChildIndex, int rightChildIndex)
    {
        if (leftChildIndex >= Count)
            return null;

        var leftChild = heap[leftChildIndex];
        var rightChild = rightChildIndex < Count ? heap[rightChildIndex] : default;

        return leftChild.CompareTo(rightChild) > 0
            ? Tuple.Create(leftChild, leftChildIndex)
            : Tuple.Create(rightChild, rightChildIndex);
    }

    private int GetChildIndex(int index)
    {
        return (index * 2) + 1;
    }
}
