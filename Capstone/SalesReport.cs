using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone
{
    public class SalesReport
    {
        public string OutputFile()
        {
            DateTime today = DateTime.Today;
            string outputDirectory = @"..\..\..\..";
            string outputFileName = $"SalesReport{today}.txt";
            string outputFullPath = Path.Combine(outputDirectory, outputFileName);
            return outputFullPath;
        }

        //Contains itemID of each item and the number sold
        public Dictionary<string, int> SalesReportDictionary = new Dictionary<string, int>();

        public void GenerateEmptyReport()
        {
            Inventory inventory = new Inventory();
            foreach(KeyValuePair<string, string> kvp in inventory.GoodsKeyDictionary)
            {
                SalesReportDictionary.Add(kvp.Key, 0);
            }

        }

        public void UpdateSalesReport(string itemID)
        {
            foreach(KeyValuePair<string, int> kvp in SalesReportDictionary)
            {
                if (itemID == kvp.Key)
                {
                    int newValue = kvp.Value + 1;
                    SalesReportDictionary[kvp.Key] = newValue;
                }
            }
        }

        public string TotalSales(Dictionary<string, int> salesReport)
        {
            decimal totalSales = 0.0M;
            foreach (KeyValuePair<string, int> kvp in SalesReportDictionary)
            {
                Item item = new Item(kvp.Key);
                totalSales = item.ItemPrice * kvp.Value;
            }
            return $"Total Sales: {totalSales}";
        }




    }
}
