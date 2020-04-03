using System;
using System.Collections.Generic;
using System.Linq;

namespace CountOfOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            SortedDictionary<int, int> numsCount = new SortedDictionary<int, int>();

            foreach (var num in nums)
            {
                if (numsCount.ContainsKey(num))
                    numsCount[num]++;
                else
                    numsCount.Add(num, 1);
            }

            foreach (var item in numsCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times");
            }
        }
    }
}
