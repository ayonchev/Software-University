using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        int numberOfElements = int.Parse(Console.ReadLine());

        var elements = new List<Box<double>>();

        for (int index = 0; index < numberOfElements; index++)
        {
            double currentElement = double.Parse(Console.ReadLine());

            var currentBox = new Box<double>(currentElement);

            elements.Add(currentBox);
        }

        double elementForComparison = double.Parse(Console.ReadLine());

        int greaterElements = CompareElements<double>(elements, elementForComparison);

        Console.WriteLine(greaterElements);
    }

    static int CompareElements<T>(ICollection<Box<T>> elements, T elementForComparison)
        where T : IComparable
    {
        int countGreaterElements = 0;

        foreach (var element in elements)
        {
            if (element.CompareTo(elementForComparison))
            {
                countGreaterElements++;
            }
        }

        return countGreaterElements;
    }

    static void SwapElements<T>(IList<T> elements, int firstIndex, int lastIndex)
    {
        var temp = elements[firstIndex];
        elements[firstIndex] = elements[lastIndex];
        elements[lastIndex] = temp;
    }

    static void PrintCollection<T>(ICollection<T> elements)
    {
        foreach (var element in elements)
        {
            Console.WriteLine(element);
        }
    }
}
