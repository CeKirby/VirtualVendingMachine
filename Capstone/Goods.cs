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
            //Do we need this? I dont know. 
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

        public abstract string MakeSound();
       
        


    }
}
