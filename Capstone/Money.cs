using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Money 
    {
        public Money(decimal currentBalance)
        {
            CurrentBalance = currentBalance;
        }

        public decimal currentMoneyProvided = 0.00M;

        public decimal CurrentBalance { get; set; }
        public decimal FeedMoney(decimal money)
        {

            decimal balance = 0.0M;
            balance += money;
            return balance;
        }


    }
}