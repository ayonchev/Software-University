using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class KeyRevolver
    {
        static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            int startBulletsCount = bullets.Count;

            Queue<int> locks = new Queue<int>(Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int intelligenceValue = int.Parse(Console.ReadLine());

            int countOfBullets = 0;
            while (bullets.Count > 0 && locks.Count > 0)
            {
                

                if (bullets.Peek() <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                bullets.Pop();
                countOfBullets++;

                if (countOfBullets == gunBarrelSize && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    countOfBullets = 0;
                }
            }

            int earnedMoney = intelligenceValue - ((startBulletsCount - bullets.Count) * bulletPrice);

            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earnedMoney}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
