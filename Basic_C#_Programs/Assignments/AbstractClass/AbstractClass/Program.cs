using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating an employee object which also contains Person class
            // initializing values for properties defined in "Person" class
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            // calling employee's overridden version of the virtual abstract method "SayName()"
            // this method is responsible for printing the welcome message to the console.
            employee.SayName();
            // leaves the console open until user closes.
            Console.Read();
        }
    }
}
