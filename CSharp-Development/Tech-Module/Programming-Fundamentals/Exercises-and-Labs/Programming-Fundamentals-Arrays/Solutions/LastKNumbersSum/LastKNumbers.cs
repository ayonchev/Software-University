using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSum
{
    class LastKNumbers
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int numberOfElements = int.Parse(Console.ReadLine());

            long[] arr = new long[length];
            arr[0] = 1;

            for (int i = 1; i < length; i++)
            {
                if (i - numberOfElements >= 0)
                {
                    for (int j = 0; j <= numberOfElements; j++)
                    {
                        arr[i] += arr[i - j];
                    }
                }
                else
                {
                    for (int k = 0; k < i; k++)
                    {
                        arr[i] += arr[k];
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
