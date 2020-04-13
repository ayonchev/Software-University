using System;
using System.Collections.Generic;

public class PlayWithTrees
{
    static void Main()
    {
        var tree =
            new Tree<int>(6,
                new Tree<int>(3,
                    new Tree<int>(1),
                    new Tree<int>(5)
                ),
                new Tree<int>(8,
                    new Tree<int>(7),
                    new Tree<int>(9)
                )
            );

        Console.WriteLine("Tree (indented):");
        tree.Print();

        IEnumerable<int> collection = tree.OrderDFS();

        Console.Write("Tree nodes:");
        tree.Each(c => Console.Write(" " + c));
        Console.WriteLine();

        Console.WriteLine();

        var binaryTree =
            new BinaryTree<int>(6,
                new BinaryTree<int>(3,
                    new BinaryTree<int>(1),
                    new BinaryTree<int>(5)
                ),
                new BinaryTree<int>(8,
                    new BinaryTree<int>(7),
                    new BinaryTree<int>(9)
                )
            );

        List<int> postOrderCollection = new List<int>();
        binaryTree.EachPostOrder(postOrderCollection.Add);

        Console.WriteLine("Binary tree (indented, pre-order):");
        binaryTree.PrintIndentedPreOrder();

        Console.Write("Binary tree nodes (in-order):");
        binaryTree.EachInOrder(c => Console.Write(" " + c));
        Console.WriteLine();

        Console.Write("Binary tree nodes (post-order):");
        binaryTree.EachPostOrder(c => Console.Write(" " + c));
        Console.WriteLine();
    }
}
