using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rect
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', width));

            for (int i = 0; i < height - 2; i++)
            {
                Console.WriteLine("*" + new string(' ', width - 2) + "*");
            }

            Console.WriteLine(new string('*', width));
        }
    }
}
