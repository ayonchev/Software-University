using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class TreeReader
{
    public static Tree<int> ReadIntegerTreeValues()
    {
        int n = int.Parse(Console.ReadLine());
        Tree<int> inputTree = null;

        for (int i = 0; i < n - 1; i++)
        {
            int[] currentValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int treeValue = currentValues[0];
            int childTreeValue = currentValues[1];

            if (inputTree == null)
                inputTree = new Tree<int>(treeValue);

            Tree<int> currentNode = inputTree.GetNode(treeValue);
            currentNode.AddChild(new Tree<int>(childTreeValue));
        }

        return inputTree;
    }
}
