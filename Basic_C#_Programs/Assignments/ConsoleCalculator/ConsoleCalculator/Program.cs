using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // CONSOLE APPLICATION ASSIGNMENT 
            //--------------------------------------------

            // WELCOME MESSAGE
            Console.WriteLine("Welcome to the Console Calculator! \nHere, you will enter a number of your choice and we'll make specific calculations for you! \n\nLet's get started...\n");

            // This code will ask for a number and
            // offer an area for the user to enter their number which
            // will be stored in a string variable named "userNumber"
            // NOTE: Console.ReadLine() only accepts "string" data types
            Console.WriteLine("\nPlease enter a number: ");
            string userNumber = Console.ReadLine();

            // This code converts the user's input into an integer that
            // can be used for mathematical operations.
            // NOTE: This is prone to errors as we can't control what the user enters --
            // Therefore, if the user types "apple" we would be attempting to convert
            // apple to an integer.
            int number = Convert.ToInt32(userNumber);
            int multBy50 = number * 50; // multiplies the user's input by 50
            Console.WriteLine("\nYour number multiplied by 50 = " + multBy50.ToString());
            

            // Add 25 and Display
            Console.WriteLine("\n\nPlease enter another number for next calculation: ");
            string SecondNumber = Console.ReadLine();

            // Convert user's input and add 25
            int secNum = Convert.ToInt32(SecondNumber);
            int add25 = secNum + 25;
            Console.WriteLine("\nYour number plus 25 = " + add25.ToString());


            // Divide by 12.5 and Display
            Console.WriteLine("\n\nNext Calculations needs your number:");
            string thirdNumber = Console.ReadLine();

            float thirdNum = Convert.ToInt32(thirdNumber); // converts string to float
            float divide = thirdNum / 12.5f;
            Console.WriteLine("\nYour number divided by 12.5 = " + divide.ToString());

            // Greater Than 50 
            Console.WriteLine("\n\nEnter your number for a comparison check: ");
            string chkNumber = Console.ReadLine();

            int chkNum = Convert.ToInt32(chkNumber);
            bool check = chkNum > 50;
            Console.WriteLine("\nTrue or False: Your number is greater than 50: \n" + check.ToString());

            // Divide by 7 and Display Remainder 
            Console.WriteLine("\n\nWith this number, we will give you it's remainder. Enter a number higher than 7: ");
            string remNumber = Console.ReadLine();

            int remNum = Convert.ToInt32(remNumber);
            int remainder = remNum % 7;
            Console.WriteLine("\nYour Number's remainder is: " + remainder.ToString());
            






                



        }
    }
}
