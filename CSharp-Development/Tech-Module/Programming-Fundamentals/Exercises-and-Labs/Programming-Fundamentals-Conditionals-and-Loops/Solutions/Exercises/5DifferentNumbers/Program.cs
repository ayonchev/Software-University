namespace _5DifferentNumbers
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var startingNumber = int.Parse(Console.ReadLine());
            var endingNumber = int.Parse(Console.ReadLine());

            if (endingNumber - startingNumber >= 5)
            {
                for (int n1 = startingNumber; n1 < endingNumber; n1++)
                {
                    for (int n2 = startingNumber; n2 < endingNumber; n2++)
                    {
                        for (int n3 = startingNumber; n3 < endingNumber; n3++)
                        {
                            for (int n4 = startingNumber; n4 < endingNumber; n4++)
                            {
                                for (int n5 = startingNumber; n5 <= endingNumber; n5++)
                                {
                                    if (startingNumber <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= endingNumber)
                                    {
                                        Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
