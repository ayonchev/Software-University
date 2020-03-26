using System;

public class ClassBoxTask
{
    static void Main()
    {
        decimal length = decimal.Parse(Console.ReadLine());
        decimal width = decimal.Parse(Console.ReadLine());
        decimal height = decimal.Parse(Console.ReadLine());

        try
        {
            Box currentBox = new Box(length, width, height);
            Console.WriteLine(currentBox);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
