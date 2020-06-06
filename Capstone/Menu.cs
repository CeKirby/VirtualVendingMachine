﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{

    public class Menu 
    {
        VendingMachine vendoMatic = new VendingMachine();
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
                    vendoMatic.DisplayItems();
                    Console.WriteLine();
                    Console.WriteLine("---~*~---");
                    Console.WriteLine();
                    return true;
                case "2":
                    PurchaseItems();
                    return true;
                case "4":
                    Console.WriteLine("Hidden menu");
                    UserHiddenMenu();
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

        private void UserHiddenMenu()
        {
            throw new NotImplementedException();
        }

        
        decimal currentBalance = 0.00M;
        public void PurchaseItems()
        {
            
            Money userMoney = new Money(currentBalance);

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
            //Console.WriteLine("Current money provided: " + "$" + currentBalance);
            string userInputPurchase = Console.ReadLine();

            if (userInputPurchase == "1") //Feed Money
            {
                Console.WriteLine("Please insert money in whole dollars($1, $2, $5, or $10)");
                string currentMoneyProvidedString = Console.ReadLine();
                decimal newCurrentMoneyProvided = decimal.Parse(currentMoneyProvidedString);
                currentBalance = currentBalance + newCurrentMoneyProvided;
                Console.WriteLine("Current money provided: " + "$" + currentBalance);

                try
                {
                    using (StreamWriter sw = new StreamWriter(outputFullPath, true))
                    {
                        //currentBalance = currentBalance + newCurrentMoneyProvided;
                        //userMoney.CurrentBalance += newCurrentMoneyProvided;
                        sw.WriteLine(now.ToString() + " " + "FEED MONEY: " + "$" + newCurrentMoneyProvided + " " + "$" + currentBalance);
                        //Console.WriteLine("Current money provided: " + currentBalance);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("There was an error");
                    Console.WriteLine(e.Message);
                    //return to PurchaseItems menu and rerun
                }
                PurchaseItems();
            }
            else if (userInputPurchase == "2") //Select Product
            {
                //Print item list
                vendoMatic.DisplayItems();
                Console.WriteLine("Please enter the location code for your item.");
                string enteredItemID = Console.ReadLine().ToUpper();
                Item selectedItem = new Item(enteredItemID);

                //check if entered Item ID exists
                if (!selectedItem.ItemExists(enteredItemID))
                {
                    Console.WriteLine("You have entered an invalid item code");
                    //return to Main Menu
                }
                //else if (selectedItem.ItemExists(enteredItemID) /*&& item is SOLDOUT*/)
                //{
                //    Console.WriteLine("The item you selected is Sold Out");
                //    //return to Main Menu
                //}
                else if (currentBalance >= selectedItem.ItemPrice)
                {                    
                    vendoMatic.DispenseItem(enteredItemID);
                    vendoMatic.DispenseItemPrintOut(enteredItemID, currentBalance);
                    currentBalance = currentBalance - selectedItem.ItemPrice;
                }
                else if (currentBalance < selectedItem.ItemPrice)
                {
                    Console.WriteLine("You do not have enough money to make that purchase. Please input money.");
                }
                else
                {
                    
                }
                
                PurchaseItems();

            }
            else if (userInputPurchase == "3") //Finish Transaction
            {
                //call method GiveChange
                Money money = new Money(currentBalance);
                decimal changeNeeded = money.CurrentBalance;
                Console.WriteLine(vendoMatic.GiveChange(changeNeeded));
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
                    Console.WriteLine(e.Message);
                    //return to PurchaseItems menu and rerun
                }
                //Return to Main Menu
                Menu main = new Menu();
                main.MainMenu();

            }
        }

       
    }
}



