using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Item
    {
        public Item (string itemID)
        {
            ItemID = itemID;
        }

        public string ItemID { get; }
        public string ItemName
        {
            get
            {
                Inventory inventory = new Inventory();
                return inventory.GoodsKeyDictionary[ItemID];
            }
           
        }
        public decimal ItemPrice
        {
            get
            {
                Inventory inventory = new Inventory();
                return inventory.ItemPriceDictionary[ItemName];
            }
        }
        public string ItemType
        {
            get
            {
                string itemType = "";
                if (ItemID.Contains("A"))
                {
                    itemType = "Chips";
                } else if (ItemID.Contains("B"))
                {
                    itemType = "Candy;";
                } else if (ItemID.Contains("C"))
                {
                    itemType = "Drink";
                } else if (ItemID.Contains("D"))
                {
                    itemType = "Gum";
                }
                return itemType;
            }
        }

        public void PrintItemMessage(string ItemType)
        {
            switch (ItemType)
            {
                case "Chips":
                    Console.WriteLine("Crunch Crunch, Yum!");
                    break;
                case "Candy":
                    Console.WriteLine("Munch Munch, Yum!");
                    break;
                case "Drink":
                    Console.WriteLine("Glug Glug, Yum!");
                    break;
                case "Gum":
                    Console.WriteLine("Chew Chew, Yum!");
                    break;
                }

        }

        public bool ItemExists(string itemID)
        {
            Inventory inventory = new Inventory();
            return inventory.GoodsKeyDictionary.ContainsKey(itemID);
        }

    }
}
