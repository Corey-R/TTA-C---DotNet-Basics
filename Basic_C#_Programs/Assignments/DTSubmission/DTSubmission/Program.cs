using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTSubmission // NOTE: ensure your namespace and/or class is not named "DateTime"
{
    class Program
    {
        static void Main(string[] args)
        {
            // stores the current date and time in DateTime variable "current"
            DateTime current = DateTime.Now;
            Console.WriteLine(current); // prints the current date and time
            Console.WriteLine("Please enter a number: "); // prompts user for instruction
            // casts user input to an integer and stores it in int variable "userNumber"
            int userNumber = Convert.ToInt32(Console.ReadLine()); 
            // using DateTime method "AddHours" to add the user's number to the current time's hour
            // storing the results in a DateTime variable "addHours"
            DateTime addHours = current.AddHours(userNumber);
            // printing results to console
            Console.WriteLine("The current time + {0} is: {1}", userNumber, addHours);
            Console.Read();
        }
    }
}
