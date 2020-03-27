namespace WordInPlural
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(noun.Length - 1);
                noun += "ies";
            }
            else if (noun.EndsWith("sh") || noun.EndsWith("ch") || noun.EndsWith("o") || noun.EndsWith("s") || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                noun += "es";
            }
            else
            {
                noun += "s";
            }

            Console.WriteLine(noun);
        }
    }
}
