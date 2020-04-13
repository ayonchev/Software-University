using System;
using System.Collections.Generic;
public class Program
{
    static void Main()
    {
        Tree<int> tree = TreeReader.ReadIntegerTreeValues();

        List<int> result = new List<int>();
        GetLeaves(tree, result);
        result.Sort();

        Console.WriteLine($"Leaf nodes: {string.Join(" ", result)}");
    }

    static void GetLeaves(Tree<int> tree, List<int> result)
    {
        if (tree.Children.Count == 0)
        {
            result.Add(tree.Value);
        }

        foreach (var child in tree.Children)
        {
            GetLeaves(child, result);
        }
    }
}
