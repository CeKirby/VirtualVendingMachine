using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class Candy : Goods
    {
        public override string MakeSound()
        {
            return "Munch Munch, Yum";
        }
        public  Dictionary<string, int> GenerateTypeDictionary()
        {
            //Holds Name and Price (just for this type of good)
            Dictionary<string, int> GoodsTypeDictionary = new Dictionary<string, int>();
            using (StreamReader sr = new StreamReader(InputFile))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] goodsArray = line.Split("|");
                    if (goodsArray[0].Contains("B"))
                    {
                        GoodsTypeDictionary.Add(goodsArray[1], int.Parse(goodsArray[2]));
                    }
                }
            }

            return GoodsTypeDictionary;
        }
    }
}
