using System;

public class Program
{
    static void Main()
    {
        string[] firstFormat = Console.ReadLine().Split();
        string[] secondFormat = Console.ReadLine().Split();
        string[] thirdFormat = Console.ReadLine().Split();

        string firstFormatName = firstFormat[0] + " " + firstFormat[1];
        string address = firstFormat[2];
        string town = firstFormat[3];

        string secondFormatName = secondFormat[0];
        int litersBeer = int.Parse(secondFormat[1]);
        bool drunkOrNot = false;
        if (secondFormat[2].ToLower() == "drunk")
        {
            drunkOrNot = true;
        }

        string thirdFormatName = thirdFormat[0];
        double balance = double.Parse(thirdFormat[1]);
        string bankName = thirdFormat[2];

        var firstThreeuple = new Threeuple<string, string , string>(firstFormatName, address, town);
        var secondThreeuple = new Threeuple<string, int, bool>(secondFormatName, litersBeer, drunkOrNot);
        var thirdThreeuple = new Threeuple<string, double, string>(thirdFormatName, balance, bankName);

        Console.WriteLine(firstThreeuple);
        Console.WriteLine(secondThreeuple);
        Console.WriteLine(thirdThreeuple);
    }


}
