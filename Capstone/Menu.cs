using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{

    public class Menu
    {
        public decimal currentMoneyProvided = 0.00M;
        public decimal currentBalance = 0.00M;



        public bool MainMenu()
        {

            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
            Console.WriteLine("Please enter the number of your choice: ");
            string userInputMain = Console.ReadLine();

            switch (userInputMain)
            {
                case "1":
                    Menu displayItems = new Menu();
                    displayItems.DisplayItems();
                    Console.WriteLine();
                    Console.WriteLine("---~*~---");
                    Console.WriteLine();
                    return true;
                case "2":
                    Menu purchaseItems = new Menu();
                    purchaseItems.PurchaseItems();
                    return true;
                case "4":
                    Menu hiddenMenu = new Menu();
                    hiddenMenu.UserHiddenMenu();
                    Console.WriteLine("Hidden menu");
                    Console.WriteLine();
                    Console.WriteLine("---~*~---");
                    Console.WriteLine();
                    return true;
                case "3":
                    Console.WriteLine("Thank you! Please come again!");
                    return false;
                default:
                    return true;
            }
        }

        public void DisplayItems()
        {
            Inventory inventory = new Inventory();
            foreach (KeyValuePair<string, string> kvp in inventory.GoodsKeyDictionary)
            {
                Item item = new Item(kvp.Key);
                VendingMachine vendoMatic = new VendingMachine();
                Console.WriteLine($"{kvp.Key}] {kvp.Value} - ${item.ItemPrice}  Available: {vendoMatic.VendingMachineStock[kvp.Key]}");

            }
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
                }
                else if (selectedItem.ItemExists(enteredItemID) /*&& item is SOLDOUT*/)
                {
                    Console.WriteLine("The item you selected is Sold Out");
                    //return to Main Menu
                }
                else
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
                //Return to Main Menu
                Menu main = new Menu();
                main.MainMenu();

            }
        }

       
    }
}



