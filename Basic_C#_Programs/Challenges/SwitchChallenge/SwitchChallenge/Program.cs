using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // SWITCH CHALLENGE

            Console.WriteLine("Please enter a number between 0 and 4: ");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("\nCool number");
                    break;
                case 2:
                    Console.WriteLine("\nAwesome number!");
                    break;
                case 3:
                    Console.WriteLine("\nThree's a crowd");
                    break;
                default:
                    Console.WriteLine("\nPlease enter 1, 2, or 3");
                    break;
            }
            Console.Read();


        }
    }
}
