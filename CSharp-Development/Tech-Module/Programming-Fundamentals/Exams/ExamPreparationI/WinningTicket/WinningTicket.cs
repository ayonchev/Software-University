using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinningTicket
{
    class WinningTicket
    {
        static void Main(string[] args)
        {
            //string[] tickets = Console.ReadLine()
            //    .Split(new char[] { ',', ' ' }, 
            //    StringSplitOptions.RemoveEmptyEntries);

            //foreach (var ticket in tickets)
            //{
            //    if (ticket.Length == 20)
            //    {

            //    }
            //    else
            //    {
            //        Console.WriteLine("invalid ticket");
            //    }
            //}

            string pattern = @"([$@#^]{6,10})";
            string input = @"Cash$$$$$$Ca$$$$$$sh
$$$$$$$$$$$$$$$$$$$$   ,   aabb  ,     th@@@@@@eemo@@@@@@ey";
            Console.WriteLine(Regex.IsMatch(input, pattern));
            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }
        }  
    }
}
