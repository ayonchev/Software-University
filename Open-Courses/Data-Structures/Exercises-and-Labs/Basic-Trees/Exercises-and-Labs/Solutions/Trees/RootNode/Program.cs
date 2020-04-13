using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static Tree<int> inputTree = null;
    static void Main()
    {
        inputTree = TreeReader.ReadIntegerTreeValues();
        Console.WriteLine($"Root node: {inputTree.Value}");
    }
}
