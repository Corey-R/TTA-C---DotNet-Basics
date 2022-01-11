using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // STRING ASSIGNMENT
            //========================

            // String Concatenation 
            //--------------------------

            // Concatenate 3 strings
            // NOTE: Space added at the end of fName and mName to show
            // "Corey Antonio Reid" instead of "CoreyAntonioReid"
            string fName = "Corey ";
            string mName = "Antonio ";
            string lName = "Reid";

            string fullName = fName + mName + lName;

            // Printing full name to console in UPPERCASE
            Console.WriteLine("My full name is: " + fullName.ToUpper());

            // StringBuilding A Paragraph
            //----------------------------------

            // Use StringBuilder to create a paragraph one sentence at a time.
            StringBuilder paragraph = new StringBuilder();

            // Use .Append() to add to the StringBuilder variable "paragraph"
            paragraph.Append("\n\n\tThis paragraph is being created using StringBuilder. ");
            paragraph.Append("StringBuilder is a function that allows us to add \ninformation to the same strin variable. ");
            paragraph.Append("Since strings are immutable, it cannot be changed by simply setting \nanother value to it. ");
            paragraph.Append("It's for this reason, why it's recommended to use the StringBuilder function.");

            Console.WriteLine(paragraph);
            Console.Read();

        }
    }
}
