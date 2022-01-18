using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        // ENUMS ASSIGNMENT 
        //=============================

        // NOTE: Here's the URL I used to learn about enum.Parse method
        // LINK: https://www.csharp-examples.net/string-to-enum/

        static void Main(string[] args)
        {     
            bool go = true;
            while (go)
            {
                try
                {
                    // prompts the user to enter a day of the wekk
                    Console.WriteLine("\nPlease enter the current day of the week \n(Note: enter full name of day or a number from 0 to 6 where 0 = Monday and 6 = Sunday): ");
                    // stores their input in a string variable 
                    string userInput = Console.ReadLine();
                    // using the Enum.Parse method to check if the user's input matches any of the 
                    // items in the "DaysOfTheWeek" enum method

                    DaysOfTheWeek weekDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput, true); // true = case insensitive (meaning tUEsdaY = Tuesday)

                    go = false;
                                                                                                                            // printing message confirming the user's input was a match
                    Console.WriteLine("So, it is {0} for you? I hope you're making the most out of your day!", weekDay);
                }
                // an exception that catches if the user's input doesn't match any items in the enum method
                catch (ArgumentException)
                {
                    // prints error message
                    Console.WriteLine("Please enter an actual day of the week");
                }
            }
           
            Console.Read();
            

            
        }
    }
}
