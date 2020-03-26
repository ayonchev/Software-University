using System;
using System.Text;

namespace RecursiveDrawing
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int maxSymbols = int.Parse(Console.ReadLine());
            DrawFigure(maxSymbols);
        }

        static void DrawFigure(int numberOfSymbols)
        {
            if (numberOfSymbols == 0)
                return;

            Console.WriteLine(new string('*', numberOfSymbols));

            DrawFigure(numberOfSymbols - 1);

            Console.WriteLine(new string('#', numberOfSymbols));
        }
    }
}
