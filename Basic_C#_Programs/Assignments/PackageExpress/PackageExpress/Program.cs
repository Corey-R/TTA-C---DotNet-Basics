using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // PACKAGE EXPRESS: BRANCHING ASSIGNMENT
            //--------------------------------------------

            // Printing welcome message to console...
            Console.WriteLine("Welcome to Package Express! Please follow the instructions below.");

            // Retrieve user's package weight...            
            Console.WriteLine("\n\nFirst, we'll need your package's weight. Please enter 'number in lbs' of your package below: ");
            // Convert user's info to an decimal data type
            decimal pckWeight = Convert.ToDecimal(Console.ReadLine());

            // Branching statement that suggests..:
            // if weight exceeds 50, send error msg
            // otherwise, continue the program
            if (pckWeight > 50)
            {   
                Console.WriteLine("\n\nWe're sorry! A " + pckWeight + "-pound package is too heavy to be shipped via Package Express. \nHave a good day.");
                Console.Read();
            }
            // otherwise or (else) the program will continue by 
           // asking for dimensions
            else
            {
                Console.WriteLine("\nPlease give us the package width: ");
                int pckWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nPlease provide the package height: ");
                int pckHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nLastly, please provide the package length: ");
                int pckLength = Convert.ToInt32(Console.ReadLine());

                // We now need to add the three dimensions together
                // and create another branching statement...
                int total = pckWidth + pckHeight + pckLength;
                if (total > 50)
                {
                    Console.WriteLine("\n\nWe're sorry! Your " +        "package adds up to \"" + total +                "\" which is too big to be shipped via " +       "Package Express. \nHave a good day!");
                    Console.Read();
                }
                // Else, calculate the quote of the package's
                // shipping cost based on its dimensions.
                else
                {
                    decimal pckProduct = pckWidth * pckHeight *             pckLength;
                    decimal pckQuote = (pckProduct *                    pckWeight) / 100;                    
                    


                    // Print quote to the console..
                    // NOTE: To round value to 2 decimal places:
                    // use Math.Round(value, 2)
                    Console.WriteLine("\n\nThank you for " +           "choosingPackage Express for all your" +         "shipping needs. \nYour package quote " +        "calculates to: $" + Math.Round(pckQuote,        2) + "!");
                    Console.Read();

                }
            }
        }
    }
}
