using System;

namespace Capstone
{
    public class Program
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
                //Should I make a seperate class or helper that holds code for each option?
                Console.WriteLine("Beverages + quantityRemaining(Inherited from class?)");
                Console.WriteLine("Candy + quantityRemaining(Inherited from class?)");
                Console.WriteLine("Chips + quantityRemaining(Inherited from class?)");
                Console.WriteLine("Gum + quantityRemaining(Inherited from class?)");
            }
            else if (userInputMain == "2")
            {
                Console.WriteLine("(1) Feed Money");
                Console.WriteLine("(2) Select Product");
                Console.WriteLine("(3) Finish Transaction");
            }
            else if (userInputMain == "4")
            {
                Console.WriteLine("Hidden menu");
            }
            else
                Console.WriteLine("Thanks! Come again!");
                

        }
    }

        //public void DisplayMainMenu()
        //{
        //    Console.WriteLine("Welcome to the Vendo-Matic 800!");
        //    Console.WriteLine("(1) Display Vending Machine Items");
        //    Console.WriteLine("(2) Purchase");
        //    Console.WriteLine("(3) Exit");
        //}

    
}
