using System;
using System.Collections.Generic;
using System.Text;

public class BankAccount
{
    private int id;
    private decimal balance;

    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public decimal Balance
    {
        get { return this.balance; }
        set { this.balance = value; }
    }

    public void Deposit(decimal amount)
    {
        this.balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= this.balance)
        {
            this.balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }

    public override string ToString()
    {
        return $"Account ID{this.id}, balance {this.balance:F2}";
    }
}

