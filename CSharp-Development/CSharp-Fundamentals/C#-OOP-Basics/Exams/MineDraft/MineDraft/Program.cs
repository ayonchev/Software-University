using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        DraftManager controller = new DraftManager();

        string input;
        while ((input = Console.ReadLine()) != "Shutdown")
        {
            string[] commandData = input.Split();
            string commandType = commandData[0];

            List<string> arguments = commandData.Skip(1).ToList();
            switch (commandType)
            {
                case "RegisterHarvester":
                    Console.WriteLine(controller.RegisterHarvester(arguments));
                    break;
                case "RegisterProvider":
                    Console.WriteLine(controller.RegisterProvider(arguments));
                    break;
                case "Day":
                    Console.WriteLine(controller.Day());
                    break;
                case "Mode":
                    Console.WriteLine(controller.Mode(arguments));
                    break;
                case "Check":
                    Console.WriteLine(controller.Check(arguments));
                    break;
            }
        }

        Console.WriteLine(controller.ShutDown());
    }
}