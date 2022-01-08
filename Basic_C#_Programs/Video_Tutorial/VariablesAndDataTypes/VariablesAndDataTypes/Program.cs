using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {        
        static void Main(string[] args)
        {
            // This is a simple program 

            //Console.WriteLine("what is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("your name is: " + yourName);
            //Console.Read();

            // This program uses variables, casting, and basic math logic

            //Console.WriteLine("What is your favorite number?");
            // NOTE: Console.ReadLine() only takes string values 
            // Therefore, casting (or converting data types) is used
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.Read();

            // Various Data Types 
            bool isStudying = false; // Boolean data type
            byte hoursWorked = 42; // Byte data type represents int from 0 to 255
            sbyte currentTemperature = -23; // sbyte (or signed byte) data type
            char questionMark = '\u2103'; // Char data type (a single unicode character)

            decimal moneyInBank = 100.5m; // Decimal data type requires "m" suffix 

            double heightInCentimeters = 211.282803584; // Double data type

            float secondsLeft = 2.62f; // Float data type requires "f" suffix or error

            short temperatureOnMars = -341; // Short Data Type (-32,000 to 32,000)

            string myName = "jesse"; // String data type

            // CASTING EXAMPLES 

            // Convert to string
            int currentAge = 30;
            string yearsOld = currentAge.ToString(); // Syntax used to convert to string

            // Convert to boolean
            bool isRaining = true;
            // Another method of converting to string 
            string rainingStatus = Convert.ToString(isRaining);



            Console.WriteLine(rainingStatus);
            Console.Read();
        }
    }
}
