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
       
        


    }
}
