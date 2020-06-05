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

       
        public void DispenseItem(item)
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



        
        }

            

            
        
    }
}
