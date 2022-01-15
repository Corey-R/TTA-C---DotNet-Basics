using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE: for static classes, you don't have to instantiate it first before using it.
            // This method was called to pass in a welcome message
            Divide.Example(out string welcome);
            // prints welcome message to console
            Console.WriteLine(welcome);
            // Asks for user's name for later use
            Console.WriteLine("What's your name: ");
            string name = Console.ReadLine(); // stores user's name here
            // Asks user to enter a number 
            Console.WriteLine("\nPlease enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine()); // stores user's number here

            // calls Quotient method to perform division operation on user's number and..
            // passes the results to the output variable "number"
            Divide.Quotient(userNumber, out int number);
            // an overload method that uses two parameters, an output variable and an input variable
            Divide.Example(out string thanks, name);
            
            // prints the user's results to the console using the output variable from Quotient method
            Console.WriteLine("\nYour results: \n" + userNumber + " divided by 2 = " + number);
            // prints a thank you message to console using output variable from overloaded method
            Console.WriteLine(thanks);
            Console.Read();
        }
    }
}
