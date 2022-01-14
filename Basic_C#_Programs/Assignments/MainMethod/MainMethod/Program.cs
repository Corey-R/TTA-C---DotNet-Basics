using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating the class "Operation" as a new object
            Operation operate = new Operation();
            // Calling the 3 methods and passing their respected arguments
            int results = operate.Math(5);
            int resultsTwo = operate.Math(25.00m);
            int resultsThree = operate.Math("300");
            // printing results to the console
            Console.WriteLine(results + "\n" + resultsTwo + "\n" + resultsThree);
            Console.Read();
        }
    }
}
