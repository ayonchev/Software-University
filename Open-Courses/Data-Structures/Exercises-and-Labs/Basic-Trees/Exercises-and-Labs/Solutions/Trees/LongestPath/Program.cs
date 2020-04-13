using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main()
    {
        Tree<int> tree = TreeReader.ReadIntegerTreeValues();

        List<int> longestPath = new List<int>();
        List<int> currentPath = new List<int>();
        FindLongestPath(tree, longestPath, currentPath);

        Console.WriteLine($"Longest path: {string.Join(" ", longestPath)}");
    }

    static void FindLongestPath(Tree<int> tree, List<int> longestPath, List<int> currentPath)
    {
        currentPath.Add(tree.Value);

        if (tree.Children.Count == 0 && currentPath.Count > longestPath.Count)
        {
            //Research why if I initialize a list from given values in a deeper level, the upper levels don't reflect that change and it shows that the list has 0 items
            //longest path = new List<int>(currentPath);
            longestPath.Clear();
            currentPath.ForEach(el => longestPath.Add(el));
        }

        foreach (var child in tree.Children)
        {
            FindLongestPath(child, longestPath, currentPath);
            currentPath.Remove(child.Value);
        }
    }
}
