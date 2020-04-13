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
        int deepestNodeValue = GetDeepestNode(tree);
        Console.WriteLine($"Deepest node: {deepestNodeValue}");
    }
    static int GetDeepestNode(Tree<int> inputTree)
    {
        List<Tuple<int, int>> leaves = new List<Tuple<int, int>>();
        GetLeaves(inputTree, leaves, 0);
        int result = leaves.OrderByDescending(l => l.Item2).First().Item1;
        return result;
    }

    static int GetDeepestNodeWithManualMaxFinding(Tree<int> inputTree)
    {
        List<Tree<int>> leaves = new List<Tree<int>>();
        GetLeaves(inputTree, leaves);
        int maxDepth = 0;
        int leafValue = 0;

        foreach (var leaf in leaves)
        {
            int currentDepth = 0;
            Tree<int> currentNode = leaf;

            while (currentNode.Parent != null)
            {
                currentNode = currentNode.Parent;
                currentDepth++;
            }

            if (currentDepth > maxDepth)
            {
                maxDepth = currentDepth;
                leafValue = leaf.Value;
            }
        }

        return leafValue;
    }

    static void GetLeaves(Tree<int> tree, List<Tuple<int, int>> leaves, int level)
    {
        if (tree.Children.Count == 0)
        {
            leaves.Add(new Tuple<int, int>(tree.Value, level));
        }

        foreach (var child in tree.Children)
        {
            GetLeaves(child, leaves, level + 1);
        }
    }

    static void GetLeaves(Tree<int> tree, List<Tree<int>> leaves)
    {
        if (tree.Children.Count == 0)
        {
            leaves.Add(tree);
        }

        foreach (var child in tree.Children)
        {
            GetLeaves(child, leaves);
        }
    }
}
