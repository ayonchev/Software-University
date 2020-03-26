
namespace PasswordFinder
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            var password = "2+2=fish";
            var sum = "";
            long numOfCombinations = 0;
            for (char firstCharacter = ' '; firstCharacter <= '}'; firstCharacter++)
            {
                for (char secondChar = ' '; secondChar < '}'; secondChar++)
                {
                    for (char thirdChar = ' '; thirdChar < '}'; thirdChar++)
                    {
                        for (char fourthChar = ' '; fourthChar < '}'; fourthChar++)
                        {
                            for (char fifthChar = ' '; fifthChar < '}'; fifthChar++)
                            {
                                for (char sixthChar = ' '; sixthChar < '}'; sixthChar++)
                                {
                                    for (char seventhChar = ' '; seventhChar < '}'; seventhChar++)
                                    {
                                        for (char eighthChar = ' '; eighthChar < '}'; eighthChar++)
                                        {
                                            sum = $"{firstCharacter}{secondChar}{thirdChar}{fourthChar}{fifthChar}{sixthChar}{seventhChar}{eighthChar}";
                                            Console.WriteLine(sum);
                                            numOfCombinations++;
                                            if (sum == password)
                                            {
                                                break;
                                            }
                                        }
                                        if (sum == password)
                                        {
                                            break;
                                        }
                                    }
                                    if (sum == password)
                                    {
                                        break;
                                    }
                                }
                                if (sum == password)
                                {
                                    break;
                                }
                            }
                            if (sum == password)
                            {
                                break;
                            }
                        }
                        if (sum == password)
                        {
                            break;
                        }
                    }
                    if (sum == password)
                    {
                        break;
                    }
                }
                if (sum == password)
                {
                    break;
                }
            }

            if (sum == password)
            {
                Console.WriteLine($"Success! {numOfCombinations} combinations");
            }
        }
    }
}
