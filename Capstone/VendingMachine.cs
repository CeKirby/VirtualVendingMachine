using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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

        public void DispenseItem(string itemID)
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
        }
        public string InputFile
        {
            get
            {
                string directory = @"..\..\..\..";
                string filename = "vendingmachine.csv";
                return Path.Combine(directory, filename);
            }
        }


        
        }
 
        
    
}
