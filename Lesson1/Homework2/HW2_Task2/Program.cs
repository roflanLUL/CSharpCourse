using System;

namespace HW2_Task2
{
    class Program
    {
        enum BankAccounts
        {
            Current,
            Credit,
            Deposit,
            Budgetary
        }

        struct Information
        {
            public int number;
            public BankAccounts account;
            public decimal balance;
        }
        
        static void Main()
        {
            Information info;
            info.number = 0;
            info.account = BankAccounts.Budgetary;
            info.balance = 10005.8M;
            Console.WriteLine($"Your bank account number is {info.number}, type is {info.account}, balance is {info.balance}");
        }
    }
}