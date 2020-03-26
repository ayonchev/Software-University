using System;
using System.Linq;

namespace PredicateForNames
{
    class PredicateForNames
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Predicate<string> checkLength = name => name.Length <= nameLength;

            names = names.Where(x => checkLength(x)).ToArray();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
