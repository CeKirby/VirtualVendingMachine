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
        public string InputFile
        {
            get
            {
                string directory = @"..\..\..\..";
                string filename = "vendingmachine.csv";
                return Path.Combine(directory, filename);
            }
        }
        public Dictionary<string, string> GenerateMasterGoodsList()
        {
            //holds ID and Name
            Dictionary<string, string> GoodsList = new Dictionary<string, string>();

            using (StreamReader sr = new StreamReader(InputFile))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] goodsArray = line.Split("|");
                    GoodsList.Add(goodsArray[0], goodsArray[1]);

                }
            }

            return GoodsList;
        }
    }
}
