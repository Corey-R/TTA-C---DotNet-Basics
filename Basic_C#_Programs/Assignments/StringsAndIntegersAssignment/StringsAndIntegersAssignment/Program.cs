using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // STRINGS AND INTEGERS SUBMISSION ASSIGNMENT
            //==================================================================

            // creating a list of integers
            List<int> dividends = new List<int>() { 19, 33, 47, 1 };

            // prompt user to enter a number and store their input
            Console.WriteLine("Please enter a number.");
                        

            // adding a try/catch block to catch exceptions
            try
            {
                int divisor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nYour results: ");
                // create for loop that iterates the number list and divides each by the user's number
                foreach (int dividend in dividends)
                {
                    int quotient = dividend / divisor;
                    Console.WriteLine("\n" + dividend + " / " + divisor + " = " + quotient);
                }
            }
            catch (DivideByZeroException ex) // catches when user enters 0
            {
                // prints custom error message to console
                Console.WriteLine("\nThis calculation cannot be performed. Do not enter '0'.");
            }
            catch (FormatException ex) // catches when user enters letters instead of numbers
            {
                Console.WriteLine("\nYou must enter a valid number. No letters (e.g. 8, 17, 5, etc.)");
            }
            catch (Exception ex) // catches any general exceptions
            {
                Console.WriteLine(ex.Message);
            }
            // performed outside the try/catch block (will display regardless of the outcome)
            finally
            {
                // print to console that try/catch block has ended and program will continue
                Console.WriteLine("\n\nTry/catch block has ended.. \nContinuing Program...");
                Console.Read(); // keeps console open 
            }           
        }
    }
}
