using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public abstract class Goods
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
        public virtual Dictionary<string, int> GenerateTypeDictionary()
        {
            //Holds Name and Price (called in each type object candy, gum, etc.)
            Dictionary<string, int> GoodsTypeDictionary = new Dictionary<string, int>();
            using (StreamReader sr = new StreamReader(InputFile))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] goodsArray = line.Split("|");
                    GoodsTypeDictionary.Add(goodsArray[1], int.Parse(goodsArray[2]));

                }
            }

            return GoodsTypeDictionary;
        }
        public abstract string MakeSound();
       
        


    }
}
