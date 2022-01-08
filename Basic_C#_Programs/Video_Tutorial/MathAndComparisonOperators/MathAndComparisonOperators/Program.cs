using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.Read();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five = " + difference.ToString());
            //Console.Read();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.Read();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.Read();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.Read();

            // COMPARISON OPERATORS
            //--------------------------------------

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.Read();

            int roomTemperature = 70;
            int currentTemperature = 70;

            // creating a variable of data type boolean named "isWarm"
            //  bool isWarm = currentTemperature <= roomTemperature;
            
            bool isWarm = currentTemperature != roomTemperature;
            Console.WriteLine(isWarm);
            Console.Read();

        }
    }
}
