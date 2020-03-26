using System;
using System.Runtime.InteropServices;

namespace KnightsOfHonor
{
    class KnightsOfHonor
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Action<string> printName = name => Console.WriteLine($"Sir {name}");

            foreach (var name in names)
            {
                printName(name);
            }
        }
    }
}
