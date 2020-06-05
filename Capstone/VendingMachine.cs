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

        public void PrintItemsAvailable()
        {

        }

        public void DispenseItemPrintOut(string itemID, decimal currentBalance)
        {
            Item item = new Item(itemID);
            Console.WriteLine($"Dispensing your {item.ItemName}. It cost {item.ItemPrice}. You have a remaining balance of {currentBalance}");
        }
    }
}
