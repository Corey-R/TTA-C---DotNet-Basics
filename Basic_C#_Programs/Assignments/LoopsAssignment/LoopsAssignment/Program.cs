using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // LOOPS SUBMISSION ASSIGNMENT 
            //----------------------------------

            // While Loop Section
            //-----------------------

            Console.WriteLine("Enter a number between 0 and 5");            
            // Set bool variable for while loop
            bool go = true;

            // This code says:
            // While true, get user's number and run branching statement
            while (go)
            {
                int number = Convert.ToInt32(Console.ReadLine());

                // If user's number is between 0 and 5, print "Happy Coder"
                // to console n number of times.
                if (number > 0 && number < 5)
                {
                    // This while loop says:
                    // While user's number is less than 5, continue to print
                    // "Happy coder"
                    while (number < 5)
                    {
                        Console.WriteLine("Happy Coder " + number);
                        number++; // adds user's number by 1 
                        go = false;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number between 0 and 5.");
                }
            }                        

            // Do While Loop Section
            //---------------------------------            

            Console.WriteLine("\n\nNow, Guess how old I am? ");
            int age = Convert.ToInt32(Console.ReadLine());
            bool guess = age == 30;
            do
            {
                switch (age)
                {
                    case 33:
                        Console.WriteLine("\nIncorrect Guess! 33 is too high.");
                        Console.WriteLine("\n\nNow, Guess how old I am? ");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("\nWrong! But how awesome would it be to be a 2 year old coder?!");
                        Console.WriteLine("\n\nNow, Guess how old I am? ");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 30:
                        Console.WriteLine("\nCorrectomundo! Great Job!!");
                        // Here, set guess to true to stop the while loop
                        guess = true;
                        break;
                    default:
                        Console.WriteLine("\nUnfortunately, your guess is incorrect. \nHere's a hint: I was born somewhere between 1970 and 2000. Good Luck!");
                        Console.WriteLine("\n\nNow, Guess how old I am? ");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                }                
            }
            // This while states:
            // While false (!) or while guess == 30
            while (!guess);
            Console.Read();
        }
    }
}
