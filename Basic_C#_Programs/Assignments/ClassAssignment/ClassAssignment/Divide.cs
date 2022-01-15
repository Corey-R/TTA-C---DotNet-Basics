using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    // made Divide class public and static
    // public allows access to other programs to use this class
    // static allows other programs to use this class without instantiating an object first
    public static class Divide
        // NOTE: if class is static, remember to make all class members and methods static as well
    {
        // creating a static method dividing the data by 2
        public static void Quotient(int userNumber, out int number)
        {            
            number = userNumber / 2;
        }

        // creating a static method with output parameters
        public static void Example(out string thanks, string name)
        {
            thanks = "\n\nThank you, " + name + " for your participation!";            
        }

        // creating an overloading static method 
        // the difference is the number of parameters it requires
        public static void Example(out string welcome)
        {
            welcome = "Hello, this is a division program.";
        }
    }
}
