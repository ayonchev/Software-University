using System;
using System.Collections.Generic;

public class BinarySearchTree<T> where T : IComparable<T>
{
    private Node root;
    // In the SoftUni's implementation a Node class is presented and also, most of the things like insertion, search etc. are implemented in an iterative way.
    public BinarySearchTree()
    {
    }

    //Introducing a Node class actually makes managing references much easier. Otherwise we come to a point where ( DeleteMin ), where if we have to delete the root element, we again have to say `this = this.RightChild` or something like that. The trick is that when we introduce the nodes, we can no longer use the recursive nature of the structure, because now we are dealing with the nodes, not the tree class itself and so now we cant't say as before, `LeftChild.Insert(value)`.
    private class Node
    {
        public Node(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
    }

    public void Insert(T newValue)
    {
        if (root == null)
        {
            root = new Node(newValue);
            return;
        }

        Node parent = root;
        while (true)
        {
            if (newValue.CompareTo(parent.Value) < 0)
            {
                if (parent.LeftChild == null)
                {
                    parent.LeftChild = new Node(newValue);
                    break;
                }

                parent = parent.LeftChild;
            }
            else if (newValue.CompareTo(parent.Value) > 0)
            {
                if (parent.RightChild == null)
                {
                    parent.RightChild = new Node(newValue);
                    break;
                }

                parent = parent.RightChild;
            }
            else
            {
                break;
            }
        }
    }

    public bool Contains(T searchedValue)
    {
        Node resultNode = FindElement(searchedValue);
        return resultNode != null;
    }


    public BinarySearchTree<T> Search(T searchedValue)
    {
        Node foundNode = FindElement(searchedValue);
        BinarySearchTree<T> copiedTree = new BinarySearchTree<T>();

        if (foundNode == null)
        {
            return new BinarySearchTree<T>();
        }
        else
        {
            PreOrderCopy(foundNode, copiedTree);
        }

        return copiedTree;
    }

    private void PreOrderCopy(
        Node sourceNode,
        BinarySearchTree<T> resultTree)
    {
        resultTree.Insert(sourceNode.Value);

        if (sourceNode.LeftChild != null)
        {
            PreOrderCopy(sourceNode.LeftChild, resultTree);
        }
        if (sourceNode.RightChild != null)
        {
            PreOrderCopy(sourceNode.RightChild, resultTree);
        }
    }

    /*private BinarySearchTree<T> BFSCopy(BinarySearchTree<T> sourceTree)
    {
        BinarySearchTree<T> copiedTree = new BinarySearchTree<T>();
        Queue<BinarySearchTree<T>> unprocessedSubTrees = new Queue<BinarySearchTree<T>>();
        unprocessedSubTrees.Enqueue(sourceTree);

        while (unprocessedSubTrees.Count > 0)
        {
            BinarySearchTree<T> currentTree = unprocessedSubTrees.Dequeue();

            if (currentTree.LeftChild != null)
            {
                unprocessedSubTrees.Enqueue(currentTree.LeftChild);
            }
            if (currentTree.RightChild != null)
            {
                unprocessedSubTrees.Enqueue(currentTree?.RightChild);
            }

            copiedTree.Insert(currentTree.Value);
        }

        return copiedTree;
    }*/

    private Node FindElement(T searchedValue)
    {
        Node current = root;
        while (current != null)
        {
            if (searchedValue.CompareTo(current.Value) < 0)
            {
                current = current.LeftChild;
            }
            else if (searchedValue.CompareTo(current.Value) > 0)
            {
                current = current.RightChild;
            }
            else
            {
                return current;
            }
        }

        return null;
    }
    public void DeleteMin()
    {
        //It's hard to actually solve this problem recursively, because when we get to the point where the element has no left child (meaning it's the smallest), and if it has a right child, we can't actually assign the right child to the current reference. We can't say `this = this.RightChild;`.
        if (this.root == null)
        {
            return;
        }

        Node current = this.root;
        Node parent = null;

        while (current.LeftChild != null)
        {
            parent = current;
            current = current.LeftChild;
        }

        if (parent == null)
        {
            this.root = current.RightChild;
        }
        else
        {
            parent.LeftChild = current.RightChild;
        }
    }

    public IEnumerable<T> Range(T startRange, T endRange)
    {
        Queue<T> result = new Queue<T>();
        Range(this.root, startRange, endRange, result);

        return result;
    }

    //In this method we use in order traversal. We check if the current node has left child and is bigger or equal to the startRange, and if it's not, there is no sense in going into the left child, it for sure is going to be less than the range. We check if the current node is in the whole range, and add it to the result if so. We then make similar comparison, like the first, for the right child.
    private void Range(Node node, T startRange, T endRange, Queue<T> result)
    {
        // Same as: node >= startRange. In logical terms it's more eye appealing to write it this way and easier to perceive.
        if (node.Value.CompareTo(startRange) > 0 && node.LeftChild != null)
        {
            Range(node.LeftChild, startRange, endRange, result);
        }

        if (node.Value.CompareTo(startRange) >= 0 && node.Value.CompareTo(endRange) <= 0)
        {
            result.Enqueue(node.Value);
        }

        if (node.Value.CompareTo(endRange) < 0 && node.RightChild != null)
        {
            Range(node.RightChild, startRange, endRange, result);
        }
    }

    public void EachInOrder(Action<T> action)
    {
        EachInOrder(this.root, action);
    }

    private void EachInOrder(Node node, Action<T> action)
    {
        if (node == null)
        {
            return;
        }

        EachInOrder(node.LeftChild, action);
        action.Invoke(node.Value);
        EachInOrder(node.RightChild, action);
    }
}

public class Launcher
{
    public static void Main(string[] args)
    {

    }
}
