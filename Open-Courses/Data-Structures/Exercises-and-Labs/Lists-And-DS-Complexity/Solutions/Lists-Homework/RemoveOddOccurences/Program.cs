using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveOddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Dictionary<int, int> numsCount = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (numsCount.ContainsKey(num))
                    numsCount[num]++;
                else
                    numsCount.Add(num, 1);
            }

            nums = nums.Where(n => numsCount[n] % 2 == 0).ToList();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
