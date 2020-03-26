using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 4, 5};

            Queue<int> queue = new Queue<int>(arr);

            foreach (var element in queue)
            {
                if (element > 2)
                {
                    queue.Enqueue(queue.Dequeue());
                }
            }
        }
    }
}
