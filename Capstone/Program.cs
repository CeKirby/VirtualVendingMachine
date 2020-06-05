using System;

namespace Capstone
{
    public class Program : PotenitialOptions
    {

        static void Main(string[] args)
        {
            bool showMainMenu = true;

            while (showMainMenu)
            {
                showMainMenu = MainMenu();
            }
        }
        public static bool MainMenu()
        {
            Console.WriteLine("Welcome to the Vendo-Matic 800!");
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
            Console.WriteLine("Please enter the number of your choice: ");
            string userInputMain = Console.ReadLine();

            switch (userInputMain)
            {
                case "1":
                    PotenitialOptions displayItems = new PotenitialOptions();
                    displayItems.DisplayItems();
                    return true;
                case "2":
                    PotenitialOptions purchaseItems = new PotenitialOptions();
                    purchaseItems.PurchaseItems();
                    return true;
                case "4":
                    PotenitialOptions hiddenMenu = new PotenitialOptions();
                    hiddenMenu.UserHiddenMenu();
                    Console.WriteLine("Hidden menu");
                    return true;
                case "3":
                    Console.WriteLine("Thank you! Please come again!");
                    return false;
                default:
                    return true;
            }
        }

        //if (userInputMain == "1")
        //{
        //    PotenitialOptions displayItems = new PotenitialOptions();
        //    displayItems.DisplayItems();
        //}
        //else if (userInputMain == "2")
        //{
        //    PotenitialOptions purchaseItems = new PotenitialOptions();
        //    purchaseItems.PurchaseItems();

        //}
        //else if (userInputMain == "4")
        //{
        //    PotenitialOptions hiddenMenu = new PotenitialOptions();
        //    hiddenMenu.UserHiddenMenu();
        //    Console.WriteLine("Hidden menu");
        //}            
        //else
        //    Console.WriteLine("Thank you! Please come again!");

    }
}
