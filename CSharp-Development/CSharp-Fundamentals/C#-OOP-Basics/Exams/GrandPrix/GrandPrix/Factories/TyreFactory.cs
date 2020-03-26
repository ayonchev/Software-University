using System;
using System.Collections.Generic;
using System.Text;

public static class TyreFactory
{
    public static Tyre CreateTyre(List<string> commandArgs)
    {
        string type = commandArgs[0];
        double hardness = double.Parse(commandArgs[1]);

        switch (type)
        {
            case "Ultrasoft":
                return new UltrasoftTyre(hardness, double.Parse(commandArgs[3]));
            case "Hard":
                return new HardTyre(hardness);
        }

        return null;
    }
}

