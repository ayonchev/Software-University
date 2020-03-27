using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingIntegers
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                long currNumber = long.Parse(input);
                Console.WriteLine($"{currNumber} can fit in:");
                if (currNumber >= sbyte.MinValue && currNumber <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (currNumber >= byte.MinValue && currNumber <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }
                if (currNumber >= short.MinValue && currNumber <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }
                if (currNumber >= ushort.MinValue && currNumber <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (currNumber >= int.MinValue && currNumber <= int.MaxValue)
                {
                    Console.WriteLine("* int");
                }
                if (currNumber >= uint.MinValue && currNumber <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }
                Console.WriteLine("* long");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
