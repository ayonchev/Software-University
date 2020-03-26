namespace TriplesOfLetters
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            for (int firstLetter = 0; firstLetter < count; firstLetter++)
            {
                for (int secondLetter = 0; secondLetter < count; secondLetter++)
                {
                    for (int thirdLetter = 0; thirdLetter < count; thirdLetter++)
                    {
                        Console.WriteLine($"{(char)(firstLetter + 'a')}{(char)(secondLetter + 'a')}{(char)(thirdLetter + 'a')}");
                    }
                }
            }
        }
    }
}
