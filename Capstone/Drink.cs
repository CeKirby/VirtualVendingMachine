using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Drink : Goods
    {
        public override string MakeSound()
        {
            return "Glu Glug, Yum!";
        }
    }
}
