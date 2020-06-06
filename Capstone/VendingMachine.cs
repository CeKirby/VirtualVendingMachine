﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class VendingMachine
    {



        //public Dictionary<string, int> VendingMachineStock
        //{
        //    get
        //    {
        //        Dictionary<string, int> vendingMachineSlots = new Dictionary<string, int>
        //        {
        //            {"A1", 0 }, {"A2", 0 }, {"A3", 0 }, {"A4", 0 },
        //            {"B1", 0 }, {"B2", 0 }, {"B3", 0 }, {"B4", 0 },
        //            {"C1", 0 }, {"C2", 0 }, {"C3", 0 }, {"C4", 0 },
        //            {"D1", 0 }, {"D2", 0 }, {"D3", 0 }, {"D4", 0 },
        //        };
        //        return vendingMachineSlots;
        //    }
        //}

        //public void Restock(Dictionary<string, int> vendingMachineStock)
        //{
        //    foreach (KeyValuePair<string, string> kvp in vendingMachineInventory.GoodsKeyDictionary)
        //    {
        //        vendingMachineStock.Add(kvp.Key, 5);
        //    }

        //}
        Inventory inventory = new Inventory();
        public void DispenseItem(string itemId)
        {
            int currentNumber = inventory.stock[itemId];
            inventory.stock[itemId] = --currentNumber;
        }
        public void DisplayItems()
        {
            
            foreach (KeyValuePair<string, string> kvp in inventory.GoodsKeyDictionary)
            {
                Item item = new Item(kvp.Key);
                Console.WriteLine($"{kvp.Key}] {kvp.Value} - ${item.ItemPrice}  Available: {inventory.stock[kvp.Key]}");

            }
        }
        public void DispenseItemPrintOut(string itemID, decimal currentBalance)
        {
            Item item = new Item(itemID);            
            Console.WriteLine($"Dispensing your {item.ItemName}. It cost {item.ItemPrice}. You have a remaining balance of {currentBalance - item.ItemPrice}");
            item.PrintItemMessage(item.ItemType);
            currentBalance = currentBalance - item.ItemPrice;
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
