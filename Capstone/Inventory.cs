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
        public void DisplayItems()
        {

            foreach (KeyValuePair<string, string> kvp in GoodsKeyDictionary)
            {
                Item item = new Item(kvp.Key);
                Console.WriteLine($"{kvp.Key}] {kvp.Value} - ${item.ItemPrice}  Available: itemsLeft");

            }
            
        }

        //public Dictionary<string, int> stock = new Dictionary<string, int>();
        public Dictionary<string, int> stock
        {
            get
            {
                Dictionary<string, int> vendingMachineSlots = new Dictionary<string, int>
                {
                    {"A1", 5 }, {"A2", 0 }, {"A3", 0 }, {"A4", 0 },
                    {"B1", 0 }, {"B2", 0 }, {"B3", 0 }, {"B4", 0 },
                    {"C1", 0 }, {"C2", 0 }, {"C3", 0 }, {"C4", 0 },
                    {"D1", 0 }, {"D2", 0 }, {"D3", 0 }, {"D4", 0 },
                };
                return vendingMachineSlots;
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
        public Dictionary<string, decimal> ItemPriceDictionary
        {
            get
            {
                Dictionary<string, decimal> PriceDictionary = new Dictionary<string, decimal>();
                using (StreamReader sr = new StreamReader(InputFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] goodsArray = line.Split("|");
                        PriceDictionary.Add(goodsArray[1], decimal.Parse(goodsArray[2]));

                    }
                }
                return PriceDictionary;
            }
        }
    }
}

