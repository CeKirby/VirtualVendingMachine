using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class FileLog
    {
        //     All purchases must be audited to prevent theft from the vending machine:
        //- Each purchase should generate a line in a file called `Log.txt`.
        //- The audit entry should be in the format: 
        //     >```
        //     > 01/01/2016 12:00:00 PM FEED MONEY: $5.00 $5.00
        //      >01/01/2016 12:00:15 PM FEED MONEY: $5.00 $10.00
        //      >01/01/2016 12:00:20 PM Crunchie B4 $10.00 $8.50
        //      >01/01/2016 12:01:25 PM Cowtales B2 $8.50 $7.50
        //      >01/01/2016 12:01:35 PM GIVE CHANGE: $7.50 $0.00

        //private static void main^ (string[] args)
        //{
        //    string outputDirectory = @"C:\Users\Student\workspace\csharp-capstone-module-1-team-3";
        //    string outputFileName = "Log.txt";
        //    string outputFullPath = Path.Combine(outputDirectory, outputFileName);
        //    DateTime now = DateTime.Now;
        //    try
        //    {
        //        using (StreamWriter sw = new StreamWriter(outputFullPath))
        //        {
        //            //every time somone feeds money, orders item, or gets change
        //            Console.WriteLine(now.ToString() + "FEED MONEY: " + "currentAmount" + "AmountFed");
        //        }
        //    } catch (Exception e)
        //    {
        //        Console.WriteLine("There was an error");
        //    }
        //}
    }
        
        
    
}
