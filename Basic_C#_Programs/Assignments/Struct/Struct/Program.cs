using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            Number number2 = number;
            number.Amount = 175m;
            number2.Amount = 200m;

            Console.WriteLine("Number 1 = {0} and Number 2 = {1}. \nThese have their own values because \"Number\" is a struct.", number.Amount, number2.Amount);
            Console.Read();
        }
    }
}
