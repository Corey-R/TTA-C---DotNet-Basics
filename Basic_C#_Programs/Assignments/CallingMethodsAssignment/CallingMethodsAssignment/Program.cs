using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // CALLING METHODS SUBMISSION ASSIGNMENT
            //=====================================================

            // Ask the user for a number to perform calculations on...
            Console.WriteLine("\nWelcome, Please enter a number and we'll use it to make vaious calculations.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // creating a new object from the class "Calculate" named calculate
            Calculate calculate = new Calculate();
            // passing in the user's number into each method to perform math operations and return 
            // results
            // each returned result is being stored in an integer variale for later use
            int addedResults = calculate.Add(userNumber);
            int multipliedResults = calculate.Multiply(userNumber);
            int subtractedResults = calculate.Subtract(userNumber);

            // printing the full results to the console...
            Console.WriteLine("\nHere's what we calculated: \n\n" + userNumber + " plus 20 = " + addedResults + "\n" + userNumber + " multiplied by 5 = " + multipliedResults + "\n" + userNumber + " subtracted from 10 = " + subtractedResults);
            Console.Read();
        }        
    }
}
