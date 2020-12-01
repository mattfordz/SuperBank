using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBank
{
    public class BankAccount
    {
        
        public decimal Balance { get; }

        private List<BankTransaction> allTransactions = new List<BankTransaction>();

        public BankAccount(decimal initialBalance)
        {
            Deposit(initialBalance);
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount invalid");
            }
            var deposit = new BankTransaction(amount);
            
            decimal balance = GetBalance();
            if(balance == 0)
            {
                Console.WriteLine($"Created a BankAccount with initial balance of {amount}");
            }
            else
            {
                Console.WriteLine($"Deposit: {amount}");
            }
            allTransactions.Add(deposit);
        }

        public void Withdraw(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount invalid");
            }
            if(Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds");
            }
            var withdrawl = new BankTransaction(-amount);
            allTransactions.Add(withdrawl);
            Console.WriteLine($"Withdraw: {amount}");
        }

        public decimal GetBalance()
        {
            decimal balance = 0;
            foreach (var item in allTransactions)
            {
                balance += item.Cash;
            }
            return balance;
        }
    }
}
