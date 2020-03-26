using System;
using System.Collections.Generic;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArr = {"cc", "ac", "bb" , "goshoAd"};
            int[] intArr = {22, 3, 6, 0, -33};

            Console.WriteLine(MaxElement(stringArr));
            Console.WriteLine(MaxElement(intArr));
        }

        private  static T MaxElement<T>(T[] elements)
            where T : IComparable
        {
            T maxElement = default(T);

            for (int index = 1; index < elements.Length; index++)
            {
                int comparison = elements[index].CompareTo(elements[index - 1]);
                if (comparison > 0)
                {
                    if (EqualityComparer<T>.Default.Equals(maxElement, default(T)) || elements[index].CompareTo(maxElement) > 0)
                    {
                        maxElement = elements[index];
                    }
                }
                else if (comparison < 0)
                {
                    if (EqualityComparer<T>.Default.Equals(maxElement, default(T)) || elements[index - 1].CompareTo(maxElement) > 0)
                    {
                        maxElement = elements[index - 1];
                    }
                }
            }

            return maxElement;
        }
    }
}
