using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace NumberWars
{
    class NumberWars
    {
        static void Main()
        {
            string[] firstInput = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            string[] secondInput = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            Queue<string> firstPlayerCards = new Queue<string>(firstInput);
            Queue<string> secondPlayerCards = new Queue<string>(secondInput);

            int count = 0;

            while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0)
            {
                string firstPlayerCard = firstPlayerCards.Dequeue();
                string secondPlayerCard = secondPlayerCards.Dequeue();

                int firstPlayerNumber = int.Parse(firstPlayerCard.Substring(0, firstPlayerCard.Length - 1));
                int secondPlayerNumber = int.Parse(secondPlayerCard.Substring(0, secondPlayerCard.Length - 1));

                if (firstPlayerNumber > secondPlayerNumber)
                {
                    firstPlayerCards.Enqueue(firstPlayerCard);
                    firstPlayerCards.Enqueue(secondPlayerCard);
                }
                else if (secondPlayerNumber > firstPlayerNumber)
                {
                    secondPlayerCards.Enqueue(secondPlayerCard);
                    secondPlayerCards.Enqueue(firstPlayerCard);
                }
                else
                {
                    
                }

                count++;
            }

            if (firstPlayerCards.Count == 0)
            {
                Console.WriteLine("second wins");
                
            }
            else
            {
                Console.WriteLine("first wins");
            }
            Console.WriteLine(count);
        }
    }
}
