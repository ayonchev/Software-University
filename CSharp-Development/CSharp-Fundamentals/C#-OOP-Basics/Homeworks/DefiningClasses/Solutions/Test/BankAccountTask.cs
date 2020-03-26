using System;
using System.Collections.Generic;

public class BankAccountTask
{
    static void Main(string[] args)
    {
        //var accounts = new Dictionary<int, BankAccount>();

        //string command;
        //while ((command = Console.ReadLine()) != "End")
        //{
        //    var currentCommand = command.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        //    var method = currentCommand[0];
        //    int id = int.Parse(currentCommand[1]);

        //    switch (method)
        //    {
        //        case "Create":
        //            Create(id, accounts);
        //            break;
        //        case "Deposit":
        //            Deposit(id, int.Parse(currentCommand[2]), accounts);
        //            break;
        //        case "Withdraw":
        //            Withdraw(id, int.Parse(currentCommand[2]), accounts);
        //            break;
        //        case "Print":
        //            Print(id, accounts);
        //            break;
        //    }
        //}
    }

    static void Print(int id, Dictionary<int, BankAccount> accounts)
    {
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine(accounts[id].ToString());
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    static void Withdraw(int id, decimal amount, Dictionary<int, BankAccount> accounts)
    {
        if (accounts.ContainsKey(id))
        {
            accounts[id].Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }
    static void Deposit(int id, decimal amount, Dictionary<int, BankAccount> accounts)
    {
        if (accounts.ContainsKey(id))
        {
            accounts[id].Deposit(amount);
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    static void Create(int id, Dictionary<int, BankAccount> accounts)
    {
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            accounts.Add(id, new BankAccount());
            accounts[id].Id = id;
        }
    }
}

