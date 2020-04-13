using System;

public class BinaryTree<T>
{
    public BinaryTree(T value, BinaryTree<T> leftChild = null, BinaryTree<T> rightChild = null)
    {
        this.Value = value;
        this.LeftChild = leftChild;
        this.RightChild = rightChild;
    }

    public T Value { get; private set; }
    public BinaryTree<T> LeftChild { get; private set; }
    public BinaryTree<T> RightChild { get; private set; }

    public void PrintIndentedPreOrder(int indent = 0)
    {
        Console.WriteLine(new string(' ', indent) + this.Value);
        LeftChild?.PrintIndentedPreOrder(indent + 2);
        RightChild?.PrintIndentedPreOrder(indent + 2);
    }

    public void EachInOrder(Action<T> action)
    {
        LeftChild?.EachInOrder(action);
        action.Invoke(this.Value);
        RightChild?.EachInOrder(action);
    }

    public void EachPostOrder(Action<T> action)
    {
        LeftChild?.EachPostOrder(action);
        RightChild?.EachPostOrder(action);
        action.Invoke(this.Value);
    }
}
