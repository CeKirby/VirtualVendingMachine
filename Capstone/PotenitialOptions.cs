using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class PotenitialOptions
    {
        decimal currentMoneyProvided = 0M;
        decimal currentBalance = 0.0M;
        public void DisplayItems()
        {
            Console.WriteLine("Beverages + quantityRemaining(Inherited from class?)");
            Console.WriteLine("Candy + quantityRemaining(Inherited from class?)");
            Console.WriteLine("Chips + quantityRemaining(Inherited from class?)");
            Console.WriteLine("Gum + quantityRemaining(Inherited from class?)");
            //if quantity = 0 Console.WriteLine("SOLD OUT")
            //Return to MainMenu
        }
        public void PurchaseItems()
        {
            Console.WriteLine("(1) Feed Money");
            Console.WriteLine("(2) Select Product");
            Console.WriteLine("(3) Finish Transaction");
            string userInputPurchase = Console.ReadLine();
            if (userInputPurchase == "1")
            {
                Console.WriteLine("Please insert money in whole dollars($1, $2, $5, or $10)");
                Console.WriteLine(currentMoneyProvided);
                //return to PurchaseItems menu and rerun
            }
            else if (userInputPurchase == "2")
            {
                //display Goods Dictionary with item name and location (A1)
                //Write another if for each of the choices and call method DispenseItem
                //if sold out Console.WriteLine("Item is sold out") and return to Purchase Menu
                //if doesn't exist Console.WriteLine("Item does not exist") and return to Purchase Menu
            }
            else if (userInputPurchase == "3")
            {
                //call method GiveChange
                currentBalance = 0;
                //return to Main Menu
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
