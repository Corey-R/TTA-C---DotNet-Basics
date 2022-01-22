using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a constant variable named "myProgram"
            const string myProgram = "Corey's Constructor Chain Program";
            var exampleVariable = myProgram; // setting string value to var variable "exampleVariable"
            Names name = new Names("Professor"); // using Constructor Chain "Names" passing in string value
            Console.WriteLine("Welcome to {0} {1}!", exampleVariable, name.FullName); // printing results
            Console.Read();

                        
             


        }
    }
}
