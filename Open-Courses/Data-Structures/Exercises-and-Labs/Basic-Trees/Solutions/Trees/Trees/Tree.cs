using System;
using System.Collections.Generic;

public class Tree<T>
{
    public Tree(T value, params Tree<T>[] children)
    {
        Value = value;
        Children = new List<Tree<T>>(children);
        foreach (var child in Children)
        {
            child.Parent = this;
        }
    }
    public T Value { get; set; }
    public Tree<T> Parent { get; set; }
    public List<Tree<T>> Children { get; set; }

    public void AddChild(Tree<T> node)
    {
        node.Parent = this;
        Children.Add(node);
    }

    public void Print(int indent = 0)
    {
        Console.WriteLine($"{new string(' ', indent)}{Value}");
        foreach (var child in Children)
        {
            child.Print(indent + 2);
        }
    }

    public void Each(Action<T> action)
    {
        action.Invoke(this.Value);
        foreach (var child in this.Children)
        {
            child.Each(action);
        }
    }

    public IEnumerable<T> OrderDFS()
    {
        List<T> result = new List<T>();
        DFS(result);

        return result;
    }

    //Iterative DFS
    private T[] DFS()
    {
        Stack<T> result = new Stack<T>();
        Stack<Tree<T>> unprocessedTrees = new Stack<Tree<T>>();
        unprocessedTrees.Push(this);

        while (unprocessedTrees.Count > 0)
        {
            Tree<T> currentNode = unprocessedTrees.Pop();

            foreach (var child in currentNode.Children)
            {
                unprocessedTrees.Push(child);
            }

            result.Push(currentNode.Value);
        }

        return result.ToArray();
    }

    //In this approach we are using the recursive nature of the Tree data structure.
    private void DFS(List<T> collection)
    {
        foreach (var child in this.Children)
        {
            child.DFS(collection);
        }

        collection.Add(this.Value);
    }

    private void DFS(Tree<T> tree, List<T> collection)
    {
        foreach (var child in tree.Children)
        {
            DFS(child, collection);
        }

        collection.Add(tree.Value);
    }

    public IEnumerable<T> OrderBFS()
    {
        List<T> result = new List<T>();

        Queue<Tree<T>> unprocessedTrees = new Queue<Tree<T>>();
        unprocessedTrees.Enqueue(this);

        while (unprocessedTrees.Count > 0)
        {
            Tree<T> currentTree = unprocessedTrees.Dequeue();
            foreach (var child in currentTree.Children)
            {
                unprocessedTrees.Enqueue(child);
            }

            result.Add(currentTree.Value);
        }

        return result;
    }

    public Tree<T> GetNode(T value)
    {
        Tree<T> node = null;
        Queue<Tree<T>> unprocessedNodes = new Queue<Tree<T>>();
        unprocessedNodes.Enqueue(this);

        while (unprocessedNodes.Count > 0 && node == null)
        {
            Tree<T> currentNode = unprocessedNodes.Dequeue();

            if (currentNode.Value.Equals(value))
                return currentNode;

            foreach (var child in currentNode.Children)
            {
                if (child.Value.Equals(value))
                    return child;

                unprocessedNodes.Enqueue(child);
            }
        }

        throw new InvalidOperationException("No such node in the tree.");
    }
}
