using System;
using System.IO;
using System.Collections.Generic;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            Candy bar = new Candy();
            
            Dictionary<string, string> master = bar.GenerateMasterGoodsList();
            Console.WriteLine(master);
        }
    }
}
