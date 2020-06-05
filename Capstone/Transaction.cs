using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class Transaction
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
        

        public void DispenseItem()
        {
            //remove item from "Stock"
        }


    }
}
