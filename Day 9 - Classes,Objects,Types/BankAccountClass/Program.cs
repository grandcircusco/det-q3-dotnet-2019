using System;
using System.Collections.Generic;

namespace BankAccountClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> bankAccounts = new List<BankAccount>
            {
                new BankAccount(200, "jfklda5656465", "Steve", "checking"),
                new BankAccount(500m, "fjdlka454", "Tom", "savings"),
                new BankAccount(1000m, "fjdkal1456", "Jerry", "savings"),
                new BankAccount(5000m, "ruowfdlk", "Ben", "checking"),
                new BankAccount(10000m, "ru3940t8jslk", "Anna", "credit")
            };

            foreach(BankAccount account in bankAccounts)
            {
                if(account.CustomerName == "Ben")
                {
                    account.PrintInfo();
                    //Get a withrawal amount from the console
                    //print "It worked, here's your money" if allowed
                    //print "Not enough money if not allowed"
                    //input
                    Console.WriteLine("How much would you like?");
                    decimal input = decimal.Parse(Console.ReadLine());

                    if (account.ApproveWithdrawal(input))
                    {
                        Console.WriteLine("Here's your money!");
                        account.Balance -= input;
                    }
                    else
                    {
                        Console.WriteLine("Oh, you don't have enough money for that.");
                    }

                }
            }


        }
    }
}
