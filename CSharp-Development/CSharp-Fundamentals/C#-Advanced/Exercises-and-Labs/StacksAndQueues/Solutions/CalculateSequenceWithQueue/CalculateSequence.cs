using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSequenceWithQueue
{
    class CalculateSequence
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int count = 0;
            long currentMember = number;
            int index = 0;

            Queue<long> result = new Queue<long>();
            result.Enqueue(currentMember);

            for (int i = 0; i < 49; i++)
            {
                if (count > 2)
                {
                    count = 0;
                    index++;
                    currentMember = result.ToArray()[index];
                }

                if (count == 0)
                {
                    result.Enqueue(currentMember + 1);
                }
                else if (count == 1)
                {
                    result.Enqueue(2 * currentMember + 1);
                }
                else if (count == 2)
                {
                    result.Enqueue(currentMember + 2);
                }

                count++;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
