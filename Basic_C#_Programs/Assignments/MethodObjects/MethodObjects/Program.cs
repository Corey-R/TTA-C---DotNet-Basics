using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating Employee class and initializing it with two string values
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            // using superClass method inherited fom class Person
            employee.SayName();
            Console.Read();
        }
    }
}
