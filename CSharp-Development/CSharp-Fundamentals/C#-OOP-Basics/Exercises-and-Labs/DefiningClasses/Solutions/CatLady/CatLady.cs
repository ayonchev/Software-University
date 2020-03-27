using System;
using System.Collections.Generic;

public class CatLady
{
    static void Main()
    {
        Dictionary<string, Cat> cats = new Dictionary<string, Cat>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] catInfo = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string catBreed = catInfo[0];
            string catName = catInfo[1];
            double catPhysics = double.Parse(catInfo[2]);

            if (!cats.ContainsKey(catName))
            {
                cats.Add(catName, new Cat(catBreed, catName, catPhysics));
            }
        }

        string catToPrint = Console.ReadLine();
        Console.WriteLine(cats[catToPrint].ToString());
    }
}
