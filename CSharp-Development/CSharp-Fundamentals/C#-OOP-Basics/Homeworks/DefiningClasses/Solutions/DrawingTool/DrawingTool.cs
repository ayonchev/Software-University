using System;
using System.Collections.Generic;
using System.Text;

public class DrawingTool
{
    public DrawingTool(int width)
    {
        Square newSquare = new Square(width);
        newSquare.Draw();
    }

    public DrawingTool(int width, int height)
    {
        Rectangle newRectangle = new Rectangle(width, height);
        newRectangle.Draw();
    }
}
