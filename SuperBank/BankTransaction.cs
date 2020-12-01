using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBank
{
    public class BankTransaction
    {
        public decimal Cash { get; }
        public DateTime Date { get; }

        public BankTransaction(decimal amount)
        {
            Cash = amount;
        }
    }
}
