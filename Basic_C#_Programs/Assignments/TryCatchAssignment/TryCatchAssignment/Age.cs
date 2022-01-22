using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    public class Age
    {
        public int userAge { get; set; }

        public void CalculateYearBorn ()
        {
            // creating bool variable for while loop
            bool validAnswer = false;
            int age = 1; // setting age a deault value
            while (!validAnswer) // while validAnswer == false;
            {
                Console.WriteLine("What is your age: "); // prints message to user
                // built in method that converts string to int returning true to validAnswer or
                // does nothing and validAnswer remains false
                validAnswer = int.TryParse(Console.ReadLine(), out age);
                // if validAnswer == false, print helpful message to user
                if (!validAnswer) Console.WriteLine("Enter a number 1 and up as your age.");
                else if (age <= 0) // if age is less than or equal to 0 (including negatives)
                {
                    throw new ArgumentOutOfRangeException(); // throw specified exception to console
                }
                else // if user's input meets all requirements
                {
                    DateTime current = DateTime.Now; // get current date and time
                    // casts the current year into an integer and subtracts the user's age to get year born
                    int yearBorn = (Int32)current.Year - age;
                    // same operation but adds one in case user's birthday has passed in the current year
                    int yearBorn2 = (Int32)current.Year - (age + 1); // taking birthday into account
                    // prints results to console 
                    Console.WriteLine("You were born in: {0} or if your birthday hasn't passed yet {1}", yearBorn, yearBorn2);
                }
            }
               
           
        }
    }
}
