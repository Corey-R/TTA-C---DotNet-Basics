using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class object
            Math math = new Math();

            // prompt user for a number
            Console.WriteLine("Hello, please enter a number: ");
            // store user's input in int variable
            int number = Convert.ToInt32(Console.ReadLine());

            //prompt user to enter optional number 
            Console.WriteLine("\nNow, enter an optional number (or leave blank and press enter): ");
            // store initial value as a string
            // This is because if the user leaves it blank it will return "" to variable
            // int data type would return an error so keep as string for now
            string times = Console.ReadLine();

            // if the user enters any value and does not leave it blank
            if (times.Length > 0)
            {
                // convert the user's now guaranteed value into an integer
                int numTimes = Convert.ToInt32(times);
                // call Add method from Math class passing in guaranteed variables
                int results = math.Add(number, numTimes);
                // print results to console
                Console.WriteLine("\nHere's your results: \n" + number + " plus 10 times " + numTimes + " = " + results);
                Console.Read();
            }
            // Otherwise, if the user leaves the optional value blank ""
            else
            {
                // call Add method from Math class containing only one guaranteed variable
                int results = math.Add(number);
                // print results to console
                Console.WriteLine("\nHere's your results: \n" + number + " plus 10 = " + results);
                Console.Read();
            }

            
        }
    }
}
