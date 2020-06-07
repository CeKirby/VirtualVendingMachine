using System;
using System.Collections.Generic;
using System.IO;

namespace Capstone
{
    public class Program : Menu
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vendo-Matic 800!");
            Menu main = new Menu();
            VendingMachine vendoMatic = new VendingMachine();
            SalesReport totalSales = new SalesReport();
            totalSales.GenerateEmptyReport();

            //Call Main Menu
            bool showMainMenu = true;
            while (showMainMenu)
            {
                showMainMenu = main.MainMenu();
            }
            totalSales.LogSalesReport();
            main.menuSpacer();
            Console.WriteLine("Thank you! Please come again!");

        }

    }
}
