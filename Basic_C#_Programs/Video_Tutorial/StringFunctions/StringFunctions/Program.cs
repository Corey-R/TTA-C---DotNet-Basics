using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jesse";
            string quote = "The man said, \"Hello\", Jesse. \nHello on a new line. \n\tHello on a tab.";
            
            // Use the @ sign to indicate everything within the quotations are 
            // part of the string (which means no escape symbols, or backslashes,
            // are needed.
            string filename = @"C:\Users\Jesse";

            // STRING FUNCTIONS 
            //=======================

            // Does the value stored in "string name" contain the letter s?
            bool trueOrFalse = name.Contains("s");

            // TrueOrFalse = does name end with "s"
            trueOrFalse = name.EndsWith("s");

            // name.length = Number of characters in string value "Jesse"
            int length = name.Length;            

            // name.ToUpper() = Places the string value in ALL CAPS ("JESSE")
            // name.ToLower() = Places the string value in all lowercase ("jesse")
            name = name.ToLower();

            // StringBuilder allows devs to add to a string value without changing
            // its contents (SideNote: Strings are immutable 

            StringBuilder sb = new StringBuilder();

            // Append() allows you to add string value to stored variable
            sb.Append("My name is Jesse.");

            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
