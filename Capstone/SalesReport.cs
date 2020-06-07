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
            DateTime now = DateTime.Now;
            string outputDirectory = @"..\..\..\..";
            string outputFileName = $"SalesReport{now}.txt";
            string outputFullPath = Path.Combine(outputDirectory, outputFileName);
            return outputFullPath;
        }

        public List<string> SalesReportList = new List<string>();

        public void UpdateSalesReport()
        {
            foreach(string update in SalesReportList)
            {

            }
        }




    }
}
