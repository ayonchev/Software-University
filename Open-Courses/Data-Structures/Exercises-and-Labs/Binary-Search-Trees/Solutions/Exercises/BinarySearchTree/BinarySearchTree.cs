using System;
using System.Collections.Generic;

public class BinarySearchTree<T> : IBinarySearchTree<T> where T : IComparable
{
    private Node root;

    private Node FindElement(T element)
    {
        Node current = this.root;

        while (current != null)
        {
            if (current.Value.CompareTo(element) > 0)
            {
                current = current.Left;
            }
            else if (current.Value.CompareTo(element) < 0)
            {
                current = current.Right;
            }
            else
            {
                break;
            }
        }

        return current;
    }

    private void PreOrderCopy(Node node)
    {
        if (node == null)
        {
            return;
        }

        this.Insert(node.Value);
        this.PreOrderCopy(node.Left);
        this.PreOrderCopy(node.Right);
    }

    private Node Insert(T element, Node node)
    {
        //We go through each node and incre
        if (node == null)
        {
            node = new Node(element);
        }
        else if (element.CompareTo(node.Value) < 0)
        {
            node.Left = this.Insert(element, node.Left);
        }
        else if (element.CompareTo(node.Value) > 0)
        {
            node.Right = this.Insert(element, node.Right);
        }

        node.Count = 1 + Count(node.Left) + Count(node.Right);

        return node;
    }

    private void Range(Node node, Queue<T> queue, T startRange, T endRange)
    {
        if (node == null)
        {
            return;
        }

        int nodeInLowerRange = startRange.CompareTo(node.Value);
        int nodeInHigherRange = endRange.CompareTo(node.Value);

        if (nodeInLowerRange < 0)
        {
            this.Range(node.Left, queue, startRange, endRange);
        }
        if (nodeInLowerRange <= 0 && nodeInHigherRange >= 0)
        {
            queue.Enqueue(node.Value);
        }
        if (nodeInHigherRange > 0)
        {
            this.Range(node.Right, queue, startRange, endRange);
        }
    }

    private void EachInOrder(Node node, Action<T> action)
    {
        if (node == null)
        {
            return;
        }

        this.EachInOrder(node.Left, action);
        action(node.Value);
        this.EachInOrder(node.Right, action);
    }

    private BinarySearchTree(Node node)
    {
        this.PreOrderCopy(node);
    }

    public BinarySearchTree()
    {
    }

    public void Insert(T element)
    {
        this.root = this.Insert(element, this.root);
    }

    public bool Contains(T element)
    {
        Node current = this.FindElement(element);

        return current != null;
    }

    public void EachInOrder(Action<T> action)
    {
        this.EachInOrder(this.root, action);
    }

    public BinarySearchTree<T> Search(T element)
    {
        Node current = this.FindElement(element);

        return new BinarySearchTree<T>(current);
    }

    public void DeleteMin()
    {
        if (this.root == null)
        {
            throw new InvalidOperationException();
        }

        Node current = this.root;
        Node parent = null;
        while (current.Left != null)
        {
            parent = current;
            current.Count--;
            current = current.Left;
        }

        if (parent == null)
        {
            this.root = current.Right;
        }
        else
        {
            parent.Left = current.Right;
        }
    }

    private Node DeleteMin(Node node)
    {
        if(node.Left == null)
        {
            return node.Right;
        }

        node.Left = DeleteMin(node.Left);
        node.Count = 1 + Count(node.Left) + Count(node.Right);

        return node;
    }

    public void DeleteMax()
    {
        if (this.root == null)
        {
            throw new InvalidOperationException();
        }

        Node parent = null;
        Node current = this.root;

        while (current.Right != null)
        {
            parent = current;
            current.Count--;
            current = current.Right;
        }

        //When the root is the biggest element.
        if (parent == null)
        {
            this.root = current.Left; //which equals this.root.Left
        }
        else
        {
            parent.Right = current.Left;
        }
    }

    private Node DeleteMax(Node node)
    {
        if(node.Right == null)
        {
            return node.Left;
        }

        node.Right = DeleteMax(node.Right);
        node.Count = 1 + Count(node.Left) + Count(node.Right);

        return node;
    }

    public IEnumerable<T> Range(T startRange, T endRange)
    {
        Queue<T> queue = new Queue<T>();

        this.Range(this.root, queue, startRange, endRange);

        return queue;
    }

    public void Delete(T element)
    {
        throw new NotImplementedException();
    }

    public int Count()
    {
        return Count(this.root);
    }

    private int Count(Node node)
    {
        if (node == null)
        {
            return 0;
        }

        return node.Count;
    }

    public int Rank(T element)
    {
        int count = this.Rank(element, this.root);

        return count;
    }

    /*Rank with in order traversal. Not so efficient as the one that uses the count.
    private void Rank(T element, Node node, ref int count)
    {
        if (node == null)
        {
            return;
        }

        //We go into the leftmost node
        Rank(element, node.Left, ref count);

        //Then we compare if the node is smaller than the element
        if (element.CompareTo(node.Value) > 0)
        {
            count++;
            Rank(element, node.Right, ref count);
        }
    }
    */

    private int Rank(T element, Node node)
    {
        if (node == null)
        {
            return 0;
        }

        if (node.Value.CompareTo(element) < 0)
        {
            // We can't use the count directly because that way we'll get the count of the whole subtree so we get the current node (1) + the count of the left child + the rank of the right child (all the subtrees that are part of the set defined by the rank).
            int rightChildRank = Rank(element, node.Right);
            return 1 + Count(node.Left) + rightChildRank;
        }
        else if (node.Value.CompareTo(element) > 0)
        {
            return Rank(element, node.Left);
        }

        //If the node value equals the element, then we return the count of the left child.
        return Count(node.Left);
    }

    public T Select(int rank)
    {
        if (this.root == null || this.root.Count <= rank)
        {
            throw new InvalidOperationException();
        }

        return Select(rank, this.root);
    }

    private T Select(int rank, Node node)
    {
        int nodeRank = Rank(node.Value);

        if (nodeRank > rank)
        {
            return Select(rank, node.Left);
        }
        else if (nodeRank < rank)
        {
            return Select(rank, node.Right);
        }

        return node.Value;
    }

    public T Ceiling(T element)
    {
        bool valueIsContained = Contains(element);
        if (!valueIsContained)
        {
            throw new InvalidOperationException();
        }

        //return this.Select(this.Rank(element) + 1);
        Node parent = null;
        Node current = this.root;

        FindElement(element);

        while (!current.Value.Equals(element))
        {
            parent = current;

            if (element.CompareTo(current.Value) < 0)
            {
                current = current.Left;
            }
            else if (element.CompareTo(current.Value) > 0)
            {
                current = current.Right;
            }

            //if (parent.Value.CompareTo(current.Value) < 0 && current.Value.CompareTo(element) > 0)
            //{
            //    break;
            //}
        }

        if (parent == null || parent.Value.CompareTo(current.Value) < 0)
        {
            if (current.Right == null)
            {
                throw new InvalidOperationException();
            }

            return current.Right.Value;
        }
        else
        {
            return parent.Value;
        }
    }

    public T Floor(T element)
    {
        bool valueIsContained = Contains(element);
        if (!valueIsContained)
        {
            throw new InvalidOperationException();
        }
        //return this.Select(this.Rank(element) - 1);

        Node parent = null;
        Node current = this.root;

        while (!current.Value.Equals(element))
        {
            parent = current;

            if (element.CompareTo(current.Value) < 0)
            {
                current = current.Left;
            }
            else if (element.CompareTo(current.Value) > 0)
            {
                current = current.Right;
            }

            //if (parent.Value.CompareTo(current.Value) < 0 && current.Value.CompareTo(element) > 0)
            //{
            //    break;
            //}
        }

        if (parent == null || parent.Value.CompareTo(current.Value) > 0)
        {
            if (current.Left == null)
            {
                throw new InvalidOperationException();
            }

            return current.Left.Value;
        }
        else
        {
            return parent.Value;
        }
    }

    private class Node
    {
        public Node(T value)
        {
            this.Value = value;
        }

        public T Value { get; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Count { get; set; }
    }
}

public class Launcher
{
    public static void Main(string[] args)
    {
        BinarySearchTree<int> bst = new BinarySearchTree<int>();

        bst.Insert(1);
        bst.Insert(3);
        bst.Insert(4);
        bst.Insert(5);
        bst.Insert(8);
        bst.Insert(9);
        bst.Insert(10);
        bst.Insert(37);
        bst.Insert(39);
        bst.Insert(45);
        bst.Insert(41);

        //bst.Insert(10);
        //bst.Insert(7);
        //bst.Insert(9);
        //bst.Insert(4);
        //bst.Insert(5);
        //bst.Insert(6);
        //bst.Insert(3);
        //bst.Insert(1);
        //bst.Insert(8);
        //bst.Insert(37);
        //bst.Insert(39);
        //bst.Insert(45);

        Console.WriteLine($"rank 8: {bst.Rank(46)}");

        bst.EachInOrder(Console.WriteLine);

        //TODO: Solve the Delete task. 
        //TODO: Remove redundant code.
        //TODO: Fix the unit tests.
    }
}