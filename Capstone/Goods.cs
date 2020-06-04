using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public abstract class Goods
    {
        public Dictionary<string, int> GenerateGoodsList()
        {
            Dictionary<string, int> GoodsList = new Dictionary<string, int>();

            return GoodsList;
        }

        public abstract string MakeSound();
       
        


    }
}
