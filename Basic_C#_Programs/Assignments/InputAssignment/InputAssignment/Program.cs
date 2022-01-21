using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // print instructions to console
            Console.WriteLine("Please enter a number: ");
            // store user's number in int variable "number"
            int number = Convert.ToInt32(Console.ReadLine());

            // using System.IO, create a new StreamWriter object that appends the user's number to a text file
            using (StreamWriter file = new StreamWriter(@"C:\Users\Corey Reid\Documents\GitHub\TTA-CSharp--DotNet-Basics\Basic_C#_Programs\Logs\Input.txt", true))
            {
                file.WriteLine("The number you enter was: {0}", number); // writes to the text file                               
            }
            
            // NOTE: by adding "using" we are getting back any unused memory (or closing the file)
            // creating a new StreamReader object to open and read the contents of a text file
            using (StreamReader display = new StreamReader(@"C:\Users\Corey Reid\Documents\GitHub\TTA-CSharp--DotNet-Basics\Basic_C#_Programs\Logs\Input.txt"))
            {
                // storing the first line of text in a string variable named "line"
                string line = display.ReadLine();
                // this while loop is used to continuing reading each line until there is no text left to read
                // which will return a value of "null"
                while (line != null)
                {
                    Console.WriteLine(line); // prints each line of text read
                    line = display.ReadLine(); // reads the next line of text and stores in "line" variable
                }
            }
            Console.Read();
        }
    }
}
