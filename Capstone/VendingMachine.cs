using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        public decimal FeedMoney(int money)
        {
            decimal balance = 0;
            balance += money;
            return balance;
        }
        public decimal ReturnMoney(decimal balance)
        {
            decimal returnedMoney = 0m;
            returnedMoney=balance;
            return returnedMoney;
        }
    }
}
