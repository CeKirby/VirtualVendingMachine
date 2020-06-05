using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    namespace Capstone
    {
        public class PotenitialOptions
        {

            decimal currentMoneyProvided = 0.00M;
            decimal currentBalance = 0.00M;
            bool showMainMenu = true;

            public void DisplayItems()
            {
                Console.WriteLine("Beverages + quantityRemaining(Inherited from class?)");
                Console.WriteLine("Candy + quantityRemaining(Inherited from class?)");
                Console.WriteLine("Chips + quantityRemaining(Inherited from class?)");
                Console.WriteLine("Gum + quantityRemaining(Inherited from class?)");
                Console.WriteLine();
                //if quantity = 0 Console.WriteLine("SOLD OUT")
                //Return to MainMenu
            }
            public void PurchaseItems()
            {
                string outputDirectory = @"C:\Users\Student\workspace\csharp-capstone-module-1-team-3";
                string outputFileName = "Log.txt";
                string outputFullPath = Path.Combine(outputDirectory, outputFileName);
                DateTime now = DateTime.Now;

                Console.WriteLine("(1) Feed Money");
                Console.WriteLine("(2) Select Product");
                Console.WriteLine("(3) Finish Transaction");
                Console.WriteLine();
                Console.WriteLine("Current money provided: " + currentBalance);
                string userInputPurchase = Console.ReadLine();

                if (userInputPurchase == "1")
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
                else if (userInputPurchase == "2")
                {
                    //display Goods Dictionary with item name and location (A1)
                    Console.WriteLine("Please enter the location code for your item.");
                    string enteredItemLocation = Console.ReadLine();
                    //Write another if for each of the choices and call method DispenseItem
                    //Copy the try method above for each case and change FEED MONEY to ITEM ORDERED and LOCATION + currentAmount + amountAfterPurchase
                    //if sold out Console.WriteLine("Item is sold out") and return to Purchase Menu
                    //if doesn't exist Console.WriteLine("Item does not exist") and return to Purchase Menu
                }
                else if (userInputPurchase == "3")
                {
                    //call method GiveChange
                    currentBalance = 0;
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

