using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ReverseAndExclude
{
    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int divisor = int.Parse(Console.ReadLine());

            Func<int, bool> filter = x => x % divisor != 0;

            numbers = numbers.Reverse().Where(filter).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
