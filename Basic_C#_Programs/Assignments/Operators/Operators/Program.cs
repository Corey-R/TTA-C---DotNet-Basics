using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating two objects with different Id value but same Name
            Employee employee = new Employee() { Id = 23, Name = "Bison" };
            Employee employee1 = new Employee() { Id = 30, Name = "Bison" };

            // storing overloaded == operator in bool variable 
            bool isEqual = employee == employee1; // NOTE: this only compares Id "see Employee class"
            Console.WriteLine(isEqual); // prints results to console
            Console.Read();
        }
    }
}
