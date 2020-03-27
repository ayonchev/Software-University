namespace firstTask
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isSpecial = false;

            for (int i = 1; i <= count; i++)
            {
                sum = i / 10 + i % 10;
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                    Console.WriteLine($"{i} -> {isSpecial}");
                }
                else
                {
                    isSpecial = false;
                    Console.WriteLine($"{i} -> {isSpecial}");
                }
            }
        }
    }
}
