using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            if (a == 5)
            {
                Console.WriteLine(5);
            }
            else if (b == 7)
            {
                Console.WriteLine(7);
            }
            else if(a == 5 && b == 7)
            {
                Console.WriteLine(57);
            }
        }
    }
}
