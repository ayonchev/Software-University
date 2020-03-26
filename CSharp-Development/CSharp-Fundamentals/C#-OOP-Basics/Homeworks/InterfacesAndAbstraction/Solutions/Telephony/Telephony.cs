using System;

class Telephony
{
    static void Main()
    {
        string[] numbersToCall = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] sitesToBrowse = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Smartphone currentPhone = new Smartphone(numbersToCall, sitesToBrowse);
        Console.WriteLine(currentPhone);
    }
}
