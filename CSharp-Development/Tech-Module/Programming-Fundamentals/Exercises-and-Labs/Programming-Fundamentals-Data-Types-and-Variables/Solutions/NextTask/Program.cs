namespace NextTask
{
    using System;
    public class Program
    {
        public static void Main()
        {
            sbyte firstNumber = sbyte.Parse(Console.ReadLine());
            byte secondNumber = byte.Parse(Console.ReadLine());
            short thirtNumber = short.Parse(Console.ReadLine());
            ushort fourthNumber = ushort.Parse(Console.ReadLine());
            uint fifthNumber = uint.Parse(Console.ReadLine());
            int sixthNumber = int.Parse(Console.ReadLine());
            long seventhNumber = long.Parse(Console.ReadLine());

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirtNumber);
            Console.WriteLine(fourthNumber);
            Console.WriteLine(fifthNumber);
            Console.WriteLine(sixthNumber);
            Console.WriteLine(seventhNumber);
        }
    }
}
