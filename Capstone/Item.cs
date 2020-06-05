using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Item : Goods
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
                return GoodsKeyDictionary[ItemID];
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

        public string ItemMessage
        {
            get
            {
                return "";
            }

        }

        public decimal ItemPrice
        {
            get
            {
                return 0.0M;
            }
        }

        public bool ItemExists(string itemID)
        {
            return GoodsKeyDictionary.ContainsKey(itemID);
        }
        public override string MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
