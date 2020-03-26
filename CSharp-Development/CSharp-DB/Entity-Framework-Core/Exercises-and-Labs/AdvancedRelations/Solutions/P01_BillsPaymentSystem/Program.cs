using Microsoft.EntityFrameworkCore;
using P01_BillsPaymentSystem.Data;
using P01_BillsPaymentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_BillsPaymentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BillsPaymentSystemContext())
            {
                Seed(context);
                context.SaveChanges();

                context.Database.Migrate();
            }
        }

        private static void Seed(BillsPaymentSystemContext context)
        {
            var users = new List<User>
                {
                    new User
                    {
                        FirstName = "Ivan",
                        LastName = "Goshev",
                        Email = "ivan@goshev.bg",
                        Password = "ivangoshevve"
                    },
                    new User
                    {
                        FirstName = "Penka",
                        LastName = "Milenove",
                        Email = "penchito@sladka.org",
                        Password = "naiqkatasum"
                    }
                };

            var creditCards = new List<CreditCard>
                {
                    new CreditCard
                    {
                        Limit = 10_000m,
                        MoneyOwed = 7800m,
                        ExpirationDate = DateTime.ParseExact("30.12.2019", "dd.MM.yyyy", null)
                    },
                    new CreditCard
                    {
                        Limit = 3000m,
                        MoneyOwed = 1500m,
                        ExpirationDate = DateTime.ParseExact("12.02.2021", "dd.MM.yyyy", null)
                    },
                };

            var bankAccounts = new List<BankAccount>
                {
                    new BankAccount
                    {
                        Balance = 100_000m,
                        BankName = "DSK",
                        SwiftCode = "DSKBANK"
                    },
                    new BankAccount
                    {
                        Balance = 300m,
                        BankName = "First Investment Bank",
                        SwiftCode = "FIBANK"
                    }
                };

            var paymentMethods = new List<PaymentMethod>
                {
                    new PaymentMethod
                    {
                        User = users[0],
                        BankAccount = bankAccounts[0],
                        Type = PaymentMethodType.BankAccount
                    },
                    new PaymentMethod
                    {
                        User = users[1],
                        CreditCard = creditCards[1],
                        Type = PaymentMethodType.CreditCard
                    },
                    new PaymentMethod
                    {
                        User = users[0],
                        CreditCard = creditCards[0],
                        Type = PaymentMethodType.CreditCard
                    }
                };

            context.Users.AddRange(users);
            context.CreditCards.AddRangeAsync(creditCards);
            context.BankAccounts.AddRange(bankAccounts);
            context.PaymentMethods.AddRange(paymentMethods);


        }
    }
}
