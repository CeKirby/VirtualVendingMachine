using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{

    public class PotentialOptions
    {
        public decimal currentMoneyProvided = 0.00M;
        public decimal currentBalance = 0.00M;

        bool showMainMenu = true;

        public void DisplayItems()//claire will fix
        {
            //Display Vending Machine Items
            Console.WriteLine();
            //if quantity = 0 Console.WriteLine("SOLD OUT")
            //Return to MainMenu
        }
        public void PurchaseItems()
        {
            VendingMachine vendingMachine = new VendingMachine();
            
            //creates path to log purchases
            string outputDirectory = @"..\..\..\..";
            string outputFileName = "Log.txt";
            string outputFullPath = Path.Combine(outputDirectory, outputFileName);
            DateTime now = DateTime.Now;
            

           //Purchase Items Menu
            Console.WriteLine("(1) Feed Money");
            Console.WriteLine("(2) Select Product");
            Console.WriteLine("(3) Finish Transaction");
            Console.WriteLine();
            Console.WriteLine("Current money provided: " + currentBalance);
            string userInputPurchase = Console.ReadLine();

            if (userInputPurchase == "1") //Feed Money
            {
                Console.WriteLine("Please insert money in whole dollars($1, $2, $5, or $10)");
                string currentMoneyProvidedString = Console.ReadLine();
                decimal newCurrentMoneyProvided = decimal.Parse(currentMoneyProvidedString);
                try
                {
                    using (StreamWriter sw = new StreamWriter(outputFullPath, true))
                    {
                        currentBalance = newCurrentMoneyProvided + currentBalance;
                        sw.WriteLine(now.ToString() + " " + "FEED MONEY: " + "$" + newCurrentMoneyProvided + " " + "$" + currentBalance);

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("There was an error");
                    //return to PurchaseItems menu and rerun
                }
                PurchaseItems();
            }
            else if (userInputPurchase == "2") //Select Product
            {
                //TODOdisplay Goods Dictionary with item name and location (A1)

                Console.WriteLine("Please enter the location code for your item.");
                string enteredItemID = Console.ReadLine();
                Item selectedItem = new Item(enteredItemID);
                //check if entered Item ID exists
                if (!selectedItem.ItemExists(enteredItemID))
                {
                    Console.WriteLine("You have entered an invalid item code");
                    //return to Main Menu
                } else if (selectedItem.ItemExists(enteredItemID) /*&& item is SOLDOUT*/)
                {
                    Console.WriteLine("The item you selected is Sold Out");
                    //return to Main Menu
                } else
                {
                    //TODO call method DispenseItem
                    vendingMachine.DispenseItemPrintOut(enteredItemID, currentBalance);
                    selectedItem.PrintItemMessage(selectedItem.ItemType);
                }

            }
            else if (userInputPurchase == "3") //Finish Transaction
            {
                //call method GiveChange
                Money money = new Money(currentBalance);
                decimal changeNeeded = money.CurrentBalance;
                Console.WriteLine(money.GiveChange(changeNeeded));
                try
                {
                    using (StreamWriter sw = new StreamWriter(outputFullPath, true))
                    {
                        sw.WriteLine(now.ToString() + " " + "GIVE CHANGE: " + currentBalance + 0.00M);

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("There was an error");
                    //return to PurchaseItems menu and rerun
                }
                //should return to Main Menu
                bool MainMenu()
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
                            PotentialOptions displayItems = new PotentialOptions();
                            displayItems.DisplayItems();
                            return true;
                        case "2":
                            PotentialOptions purchaseItems = new PotentialOptions();
                            purchaseItems.PurchaseItems();
                            return true;
                        case "4":
                            PotentialOptions hiddenMenu = new PotentialOptions();
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
            }
        }
        public void UserExits()
        {
            Console.WriteLine("Thank you! Please come again!");
        }
        public void UserHiddenMenu()
        {
            Console.WriteLine("Hidden menu");
        }
    }
}


