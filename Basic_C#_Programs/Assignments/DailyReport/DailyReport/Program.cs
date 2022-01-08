using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // daily report program
            // -------------------------

            Console.WriteLine("The Tech Academy. \nStudent Daily Report\n");

            // the "\n" are used to start the next items on a new line...

            Console.WriteLine("\n1. What is your name?");
            string yourName = Console.ReadLine(); // storing string value of user input here

            Console.WriteLine("\n2. What course are you on?");
            // the students' answer will be stored in this string variable
            string courseName = Console.ReadLine();

            Console.WriteLine("\n3. What Page Number?");
            // Though asking for a number, Console.ReadLine() only accepts...
            // string values and since no math is needed it will remain a string
            string pageNumber = Console.ReadLine();

            Console.WriteLine("\n4. Do you need help with anything? Please answer \"True\" or \"False\".");
            string needHelp = Console.ReadLine();
            // NOTE: to convert to boolean if needed...
            // bool helpAnswer = Convert.ToString(needHelp);

            Console.WriteLine("\n5. Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveXp = Console.ReadLine();

            Console.WriteLine("\n6. Is there any other feedback you'd like to provide? Please be specific.");
            string anyFeedback = Console.ReadLine();

            Console.WriteLine("\n7. How many hours did you study today?");
            string hoursStudied = Console.ReadLine();

            Console.WriteLine("\n\nThank you for your answers. An instructor will respond to this shortly. \nHave a great day!");
            Console.Read();
            


        }
    }
}
