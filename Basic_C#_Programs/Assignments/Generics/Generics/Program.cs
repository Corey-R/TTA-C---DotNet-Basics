using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating generic class with assigned "string" type and assigning a list of string
            // values to list
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "Stan", "Francine", "Ricky-Spanish", "Steve" };

            // creating generic class with type "int" and assigning collection of "ing" values
            // to list
            Employee<int> employeeAge = new Employee<int>();
            employeeAge.Things = new List<int>() { 42, 40, 75, 15 };

            // printing description of list to console
            Console.WriteLine("Actors/Actress include: \n");
            // creating a loop to display all roles to the console
            foreach (string role in employee.Things)
            {
                Console.WriteLine(role);
            }
            // printing description of ages to console
            Console.WriteLine("\nCorresponding ages are: \n");
            // creating loop to display all ages to console
            foreach(int age in employeeAge.Things)
            {
                Console.WriteLine(age);
            }
            Console.Read();

        }
    }
}
