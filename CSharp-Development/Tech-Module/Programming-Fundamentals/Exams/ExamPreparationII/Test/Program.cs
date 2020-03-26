using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';
            char b = Convert.ToChar((a.ToString().ToUpper()));
            Console.WriteLine(b);
        }
    }
}
