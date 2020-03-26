using System;
using System.Collections.Generic;
using System.Text;

public class CommandInterpreter
{
    public void InterpretCommand(string input, MyList<string> elements)
    {
        string[] command = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string commandType = command[0];

        string element;
        switch (commandType)
        {
            case "Add":
                element = command[1];
                elements.Add(element);
                break;
            case "Remove":
                int index = int.Parse(command[1]);
                elements.Remove(index);
                break;
            case "Contains":
                element = command[1];
                Console.WriteLine(elements.Contains(element));
                break;
            case "Swap":
                int firstIndex = int.Parse(command[1]);
                int secondIndex = int.Parse(command[2]);
                elements.Swap(firstIndex, secondIndex);
                break;
            case "Greater":
                element = command[1];
                int greaterElements = elements.CountGreaterThan(element);
                Console.WriteLine(greaterElements);
                break;
            case "Max":
                //Console.WriteLine(elements.Max);
                break;
            case "Min":
                //Console.WriteLine(elements.Min);
                break;
            case "Print":
                elements.Print();
                break;
            case "Sort":
                elements.Sort();
                break;
        }
    }
}
