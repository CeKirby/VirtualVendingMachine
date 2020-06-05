using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{

    public class VendingMachine
    {
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
        decimal balance = 0;
        public decimal FeedMoney(int money)
        {

            balance += money;
            return balance;
        }
        //decimal dollars = 0;
        //decimal returnedMoney = 0m;
        //public decimal ReturnMoney(decimal balance)
        //{

        //    for (decimal i = 0; i < balance; balance++)
        //        if (balance >= 1)
        //        {
        //            balance = balance - 1;
        //            dollars++;

        //        }
        //    return dollars;
        //}
        //else if (balance % 25 == 0)
        //{
        //    balance = balance - 25;
        //    decimal quarters = returnedMoney + 25;
        //    //return returnedMoney;
        //}
        //else if (balance % 10 == 0)
        //{
        //    balance = balance - 10;
        //    decimal dimes = returnedMoney + 10;
        //    //return returnedMoney;
        //}
        //else if (balance % 5 == 0)
        //{
        //    balance = balance - 5;
        //    decimal nickles = returnedMoney + 5;
        //   // return returnedMoney;
        //}
        //else
        //{
        //    Console.WriteLine("$" + dollars + "Dollars" + quarters + "Quarters" + dimes + "Dimes and" + nickles + "Nickles.");
        //    return returnedMoney;
        //}



    }
}



/*public void DispenseItem(item)
{
    balance -= DispenseItem.price;
    inventory[item]
    }

//stock list would pull in from the good class 
public void FillSlots(string[] stockList)
{
    foreach (string line in stockList)
    {
        string[] item = line.Split("|");
        Inventory.Add(item[0], new VendingMachineItem(item[1], decimal.Parse(item[2]), item[3]));// might need rearanging 
    } // filler terms inventory; vendingmachineitem;stocklist; item
}*/




//}







