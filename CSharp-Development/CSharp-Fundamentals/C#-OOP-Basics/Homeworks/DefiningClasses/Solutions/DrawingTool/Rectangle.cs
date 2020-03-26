using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void Draw()
    {
        Console.WriteLine("|" + new string('-', width) + "|");
        for (int row = 0; row < height - 2; row++)
        {
            Console.WriteLine("|" + new string(' ', width) + "|");
        }
        Console.WriteLine("|" + new string('-', width) + "|");
    }
}
