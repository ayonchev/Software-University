using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "pesho e gei";
            string newText = text.Substring(6);
            Console.WriteLine(newText);
        }
    }
}
