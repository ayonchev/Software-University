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

        List<Tree<int>> subTrees = GetSubtreesWithGivenSum(inputTree, requestedSum);
        
        Console.WriteLine($"Subtrees of sum {requestedSum}:");
        subTrees.ForEach(st =>
        {
            st.Each(node => Console.Write($"{node} "));
            Console.WriteLine();
        }
        );
    }

    static List<Tree<int>> GetSubtreesWithGivenSum(Tree<int> inputTree, int requestedSum)
    {
        List<Tree<int>> subTrees = new List<Tree<int>>();
        Queue<Tree<int>> unprocessedNodes = new Queue<Tree<int>>();
        unprocessedNodes.Enqueue(inputTree);

        while (unprocessedNodes.Count > 0)
        {
            Tree<int> currentNode = unprocessedNodes.Dequeue();
            int currentSum = GetTreeSum(currentNode);

            if (currentSum == requestedSum)
                subTrees.Add(currentNode);

            foreach (var child in currentNode.Children)
            {
                unprocessedNodes.Enqueue(child);
            }
        }

        return subTrees;
    }

    static int GetTreeSum(Tree<int> tree)
    {
        if (tree.Children.Count == 0)
        {
            return tree.Value;
        }

        int sum = tree.Value;
        foreach (var child in tree.Children)
        {
            sum += GetTreeSum(child);
        }

        return sum;
    }
}
