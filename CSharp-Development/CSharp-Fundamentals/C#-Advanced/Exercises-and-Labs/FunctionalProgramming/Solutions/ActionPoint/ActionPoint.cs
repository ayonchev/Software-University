using System;
using System.Linq;

namespace ActionPoint
{
    class ActionPoint
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Action<string> printNames = name => Console.WriteLine(name);

            foreach (var name in names)
            {
                printNames(name);
            }
        }
    }
}
