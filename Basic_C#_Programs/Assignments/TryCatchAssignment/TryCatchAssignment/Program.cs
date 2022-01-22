using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Age year = new Age(); // creating new Age object
            bool go = true; // used for while loop
            while (go) // while true
            {
                try // try this code
                {
                    year.CalculateYearBorn(); // calling void method from Age class
                    go = false; // stops while loop
                }
                catch (ArgumentOutOfRangeException) // catches any specified exceptions thrown
                {
                    Console.WriteLine("Please enter a number that is not 0 or negative"); // prints tip to user
                }
                catch (Exception) // catches any general exception thrown 
                {
                    Console.WriteLine("An unexpected error occurred...closing program."); // prints error message
                    go = false; // stops loop
                }
            }
           
           
            Console.Read();
               
        }
    }
}
