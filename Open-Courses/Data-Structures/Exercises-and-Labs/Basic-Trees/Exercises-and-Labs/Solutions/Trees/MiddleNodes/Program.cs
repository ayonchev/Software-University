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

        List<int> result = new List<int>();
        GetMiddleNodes(tree, result);
        result.Sort();

        Console.WriteLine($"Middle nodes: {string.Join(" ", result)}");
    }

    static void GetMiddleNodes(Tree<int> tree, List<int> result)
    {
        if (tree.Children.Count != 0 && tree.Parent != null)
        {
            result.Add(tree.Value);
        }

        foreach (var child in tree.Children)
        {
            GetMiddleNodes(child, result);
        }
    }
}
