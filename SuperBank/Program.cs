using System;

namespace SuperBank
{
    class Program
    {

        static void Main(string[] args)
        {
            var account = new BankAccount(10000);
            account.Withdraw(105);
            account.Deposit(54);
            Console.WriteLine($"Balance: {account.GetBalance()}");
        }
    }
}
