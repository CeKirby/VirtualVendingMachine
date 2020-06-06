using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class Inventory
    {

        public string InputFile
        {
            get
            {
                string directory = @"..\..\..\..";
                string filename = "vendingmachine.csv";
                return Path.Combine(directory, filename);
            }
        }
        public void DisplayVendingMachineItems()
        {

            foreach (KeyValuePair<string, string> kvp in GoodsKeyDictionary)
            {
                Item item = new Item(kvp.Key);
                Console.WriteLine($"{kvp.Key}] {kvp.Value} - ${item.ItemPrice}  Available: itemsLeft");

            }
        }

        //holds ID and Name
        public Dictionary<string, string> GoodsKeyDictionary
        {
            get
            {
                Dictionary<string, string> allGoods = new Dictionary<string, string>();
                using (StreamReader sr = new StreamReader(InputFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] goodsArray = line.Split("|");
                        allGoods.Add(goodsArray[0], goodsArray[1]);

                    }
                }
                return allGoods;
            }
        }
        //Holds Name and Price 
        public Dictionary<string, int> ItemPriceDictionary
        {
            get
            {
                Dictionary<string, int> PriceDictionary = new Dictionary<string, int>();
                using (StreamReader sr = new StreamReader(InputFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] goodsArray = line.Split("|");
                        PriceDictionary.Add(goodsArray[1], int.Parse(goodsArray[2]));

                    }
                }
                return PriceDictionary;
            }
        }
    }
}

