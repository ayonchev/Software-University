using System;

public static class Heap<T> where T : IComparable<T>
{
    public static void Sort(T[] arr)
    {
        for (int index = arr.Length / 2; index >= 0; index--)
        {
            HeapifyDown(arr, index, arr.Length / 2);
        }

        for (int index = arr.Length - 1; index >= 0; index--)
        {
            Swap(arr, 0, index);
            HeapifyDown(arr, 0, index);
        }
    }

    private static void HeapifyDown(T[] arr, int index, int length)
    {
        for (
            int parentIndex = index, childIndex = GetChildIndex(parentIndex);
            parentIndex < length / 2;
            parentIndex = GetChildIndex(parentIndex), childIndex = GetChildIndex(parentIndex))
        {
            var parent = arr[parentIndex];
            var child = GetBiggerChild(arr, childIndex, childIndex + 1, length);

            if (child?.Item1?.CompareTo(parent) > 0)
            {
                Swap(arr, child.Item2, parentIndex);
            }
        }
    }

    private static Tuple<T, int> GetBiggerChild(T[] arr, int leftChildIndex, int rightChildIndex, int length)
    {
        if (leftChildIndex >= length)
            return null;

        var leftChild = arr[leftChildIndex];
        var rightChild = rightChildIndex < length ? arr[rightChildIndex] : default;

        return leftChild.CompareTo(rightChild) > 0
            ? Tuple.Create(leftChild, leftChildIndex)
            : Tuple.Create(rightChild, rightChildIndex);
    }

    private static void Swap(T[] arr, int firstIndex, int secondIndex)
    {
        T firstElement = arr[firstIndex];

        arr[firstIndex] = arr[secondIndex];
        arr[secondIndex] = firstElement;
    }

    private static int GetChildIndex(int index)
    {
        return (index * 2) + 1;
    }
}
