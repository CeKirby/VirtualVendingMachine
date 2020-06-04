using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Candy : Goods
    {
        public override string MakeSound()
        {
            return "Munch Munch, Yum";
        }
    }
}
