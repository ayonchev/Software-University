using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        string[] createCommand = Console.ReadLine().Split();
        var newCollection = new ListyIterator<string>(createCommand.Skip(1).ToArray());

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            try
            {
                switch (input)
                {
                    case "HasNext":
                        Console.WriteLine(newCollection.HasNext());
                        break;
                    case "Print":
                        Console.WriteLine(newCollection.Print());
                        break;
                    case "Move":
                        Console.WriteLine(newCollection.Move());
                        break;
                    case "PrintAll":
                        Console.WriteLine(newCollection.PrintAll());
                        break;
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
