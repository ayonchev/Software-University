using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int maxSequenceCount = 0;
            int maxSequenceElement = 0;

            int currentSequenceCount = 0;
            int currentSequenceElement = 0;

            int index = 0;
            while (index < nums.Count)
            {
                currentSequenceElement = nums[index++];
                currentSequenceCount = 1;

                while (index < nums.Count && nums[index] == currentSequenceElement)
                {
                    currentSequenceCount++;
                    index++;
                }

                if(currentSequenceCount > maxSequenceCount)
                {
                    maxSequenceCount = currentSequenceCount;
                    maxSequenceElement = currentSequenceElement;
                }
            }

            for (int i = 0; i < maxSequenceCount; i++)
            {
                Console.Write(maxSequenceElement + " ");
            }
        }
    }
}
