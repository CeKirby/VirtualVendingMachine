using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class Transaction
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
    

        //holds ID and Name
        public Dictionary<string, string> MasterGoodsDictionary
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


        public string RetrieveItem(string itemID)
        {
            VendingMachine vm = new VendingMachine();
             
            string itemName = MasterGoodsDictionary[itemID];

            return itemName;
        }

        public void DispenseItem()
        {
            //remove item from "Stock"
        }


    }
}
