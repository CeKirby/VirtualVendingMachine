using System;

namespace Capstone
{
    public class Program : PotenitialOptions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vendo-Matic 800!");
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
            Console.WriteLine("Please enter the number of your choice: ");
            string userInputMain = Console.ReadLine();

            if (userInputMain == "1")
            {
                PotenitialOptions displayItems = new PotenitialOptions();
                displayItems.DisplayItems();
            }
            else if (userInputMain == "2")
            {
                //How do I run the method from another class? Sorry I forget :)
                Console.WriteLine("(1) Feed Money");
                Console.WriteLine("(2) Select Product");
                Console.WriteLine("(3) Finish Transaction");
            }
            else if (userInputMain == "4")
            {
                //How do I run the method from another class? Sorry I forget :)
                Console.WriteLine("Hidden menu");
            }
            //How do I run the method from another class? Sorry I forget :)
            else
                Console.WriteLine("Thank you! Please come again!");
        }
    }
}
