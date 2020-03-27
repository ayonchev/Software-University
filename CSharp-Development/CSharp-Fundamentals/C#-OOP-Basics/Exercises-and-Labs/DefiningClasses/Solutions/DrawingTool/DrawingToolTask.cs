using System;

public class DrawingToolTask
{
    static void Main()
    {
        string figureType = Console.ReadLine();
        int width = int.Parse(Console.ReadLine());

        if (figureType == "Rectangle")
        {
            int height = int.Parse(Console.ReadLine());

            DrawingTool newDrawingTool = new DrawingTool(width, height);
        }
        else
        {
            DrawingTool newDrawingTool = new DrawingTool(width);
        }
    }
}
