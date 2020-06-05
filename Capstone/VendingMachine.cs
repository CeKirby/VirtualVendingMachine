using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class VendingMachine
    {
        decimal balance = 0;
        public decimal FeedMoney(int money)
        {

            balance += money;
            return balance;
        }

        /// <summary>
        /// have to find a way to connect balance from above to the setter/getter below in UserCurrentBalance
        /// </summary>
        public decimal UserCurrentBalance { get; set; }
        private const decimal dollarValue = 1m;
        private const decimal quarterValue = .25M;
        private const decimal dimeValue = .10M;
        private const decimal nickelValue = .05M;

        private int dollarAmount = 0;
        private int quarterAmount = 0;
        private int dimeAmount = 0;
        private int nickelAmount = 0;
        public string FinishTransaction(decimal change)
        {
            decimal totalChange = change;
            //variables

            string result = "";
            dollarAmount = (int)(change / dollarValue);
            change -= dollarAmount / dollarValue;
            quarterAmount = (int)(change / quarterValue);
            change -= quarterAmount * quarterValue;
            dimeAmount = (int)(change / dimeValue);
            change -= dimeAmount * dimeValue;
            nickelAmount = (int)(change / nickelValue);
            change -= nickelAmount * nickelValue;
            UserCurrentBalance = 0;
            //add the transaction for the log

            if (quarterAmount == 0 && nickelAmount == 0 && dimeAmount == 0)
            {
                result = $"Your Change Is {dollarAmount} Dollar(s) For a Total of ${totalChange}.";
            }
            else if (nickelAmount == 0 && dimeAmount == 0)
            {
                result = $"Your Change Is {dollarAmount} Dollar(s) {quarterAmount} Quarter(s) For a Total of ${totalChange}.";
            }
            else if (dimeAmount == 0)
            {
                result = $"Your Change Is {dollarAmount} Dollar(s) {quarterAmount} Quarter(s) and {nickelAmount} Nickel(s) For a Total of ${totalChange}.";
            }
            else if (nickelAmount == 0)
            {
                result = $"Your Change Is {dollarAmount} Dollar(s) {quarterAmount} Quarter(s) and {dimeAmount} Dime(s) For a Total of ${totalChange}.";
            }
            else
            {
                result = $"Your Change Is {dollarAmount} Dollar(s) {quarterAmount} Quarter(s), {dimeAmount} Dime(s) and {nickelAmount} Nickel(s) For a Total of ${totalChange}.";
            }
            return result;
        }

    }
}
