using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main()
    {
        Tree<int> inputTree = TreeReader.ReadIntegerTreeValues();

        int requestedSum = int.Parse(Console.ReadLine());
        List<List<int>> allPaths = new List<List<int>>();
        List<int> path = new List<int>();
        GetAllPathsWithAGivenSum(inputTree, allPaths, path, 0, requestedSum);

        Console.WriteLine($"Paths of sum {requestedSum}:");
        foreach (var currentPath in allPaths)
        {
            Console.WriteLine(string.Join(" ", currentPath));
        }
    }

    static void GetAllPathsWithAGivenSum(
        Tree<int> tree,
        List<List<int>> allPaths,
        List<int> currentPath,
        int currentSum,
        int requestedSum)
    {
        currentPath.Add(tree.Value);
        currentSum += tree.Value;

        if (tree.Children.Count == 0 && currentSum == requestedSum)
        {
            allPaths.Add(new List<int>(currentPath));
        }

        foreach (var child in tree.Children)
        {
            GetAllPathsWithAGivenSum(child, allPaths, currentPath, currentSum, requestedSum);
            currentPath.Remove(child.Value);
        }
    }
}
