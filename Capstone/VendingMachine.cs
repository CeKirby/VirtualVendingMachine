using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class VendingMachine
    {


        public Dictionary<string, int> VendingMachineStock = new Dictionary<string, int>
        {
            {"A1", 5 }, {"A2", 5 }, {"A3", 5 }, {"A4", 5 },
            {"B1", 5 }, {"B2", 5 }, {"B3", 5 }, {"B4", 5 },
            {"C1", 5 }, {"C2", 5 }, {"C3", 5 }, {"C4", 5 },
            {"D1", 5 }, {"D2", 5 }, {"D3", 5 }, {"D4", 5 },
        };

        public void Restock(Dictionary<string, int> vendingMachineStock)
        {
            foreach (KeyValuePair<string, int> kvp in vendingMachineStock)
            {
                vendingMachineStock.Add(kvp.Key, 5);
            }
        }

        public void DispenseItem(string itemId)
        {
            int currentNumber = VendingMachineStock[itemId];
            VendingMachineStock[itemId] = --currentNumber;
        }
        public void DispenseItemPrintOut(string itemID, decimal currentBalance)
        {
            Item item = new Item(itemID);
            Console.WriteLine($"Dispensing your {item.ItemName}. It cost {item.ItemPrice}. You have a remaining balance of {currentBalance}");
            item.PrintItemMessage(item.ItemType);
        }

        
        private const decimal dollarValue = 1m;
        private const decimal quarterValue = .25M;
        private const decimal dimeValue = .10M;
        private const decimal nickelValue = .05M;

        private int dollarAmount = 0;
        private int quarterAmount = 0;
        private int dimeAmount = 0;
        private int nickelAmount = 0;
        public string GiveChange(decimal change)
        {
            Money money = new Money(change);
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

            //print-out of change 
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
