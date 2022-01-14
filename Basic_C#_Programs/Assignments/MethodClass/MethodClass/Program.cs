using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating Equation class
            Equation equate = new Equation();
            // calling Multiply method passing in respected arguments
            equate.Multiply(25, out int display);

            // calling Multiply method with named variables of their respected arguments
            // NOTE: uncomment (ctrl + k + u) the below code 
            // equate.Multiply(number: 25, display: out int display);

            // prints out the second integer as requested 
            Console.WriteLine(display);
            Console.Read();
        }
    }
}
