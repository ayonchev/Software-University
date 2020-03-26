namespace MagicLetter
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var startingLetter = char.Parse(Console.ReadLine());
            var endingLetter = char.Parse(Console.ReadLine());
            var forbiddenLetter = char.Parse(Console.ReadLine());


            for (char firstLetter = startingLetter; firstLetter <= endingLetter; firstLetter++)
            {
                for (char secondLetter = startingLetter; secondLetter <= endingLetter; secondLetter++)
                {
                    for (char thirdLetter = startingLetter; thirdLetter <= endingLetter; thirdLetter++)
                    {
                        if (firstLetter != forbiddenLetter && secondLetter != forbiddenLetter && thirdLetter != forbiddenLetter)
                        {
                            Console.Write($"{firstLetter}{secondLetter}{thirdLetter} ");
                        }
                    }
                }
            }
        }
    }
}
