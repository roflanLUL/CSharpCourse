using System;

namespace HW2_Task1
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
        static void Main()
        {
            BankAccounts account = BankAccounts.Credit;
            Console.WriteLine($"Your bank account type is {account}.");
        }
    }
}