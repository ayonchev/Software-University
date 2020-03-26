using System;

public class Program
{
    static void Main()
    {
        //var interpreter = new CommandInterpreter();

        //string input;
        //while ((input = Console.ReadLine()) != "END")
        //{
        //    interpreter.InterpretCommand(input, newList);
        //}

        var newList = new MyList<string>();
        newList.Add("aa");
        newList.Add("cc");
        newList.Add("bb");
        Console.WriteLine(newList.Min());
    }
}
