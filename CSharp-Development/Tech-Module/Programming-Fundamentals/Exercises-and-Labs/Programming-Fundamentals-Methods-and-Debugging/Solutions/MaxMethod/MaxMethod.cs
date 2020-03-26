using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int c = GetMax();
            int d = int.Parse(Console.ReadLine());
            if (c > d)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(d);
            }
        }

        static int GetMax()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
