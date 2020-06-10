using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{

    public abstract class Menu
    {

        public void menuSpacer()
        {
            Console.WriteLine();
            Console.WriteLine("---~*~---");
            Console.WriteLine();
        }

        public abstract string InvalidOption();


    }
}



