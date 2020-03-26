using System;
using System.Collections.Generic;
using System.Text;

public class Square
{
    private int width;
    public Square(int width)
    {
        this.width = width;
    }

    public void Draw()
    {
        Console.WriteLine("|" + new string('-', width) + "|");
        for (int row = 0; row < width - 2; row++)
        {
            Console.WriteLine("|" + new string(' ', width) + "|");
        }
        Console.WriteLine("|" + new string('-', width) + "|");
    }
}
