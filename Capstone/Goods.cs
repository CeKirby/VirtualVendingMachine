using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public abstract class Goods
    {

        public abstract string MakeSound();

        public List<string> Stock { get; set; }

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


    }
}
