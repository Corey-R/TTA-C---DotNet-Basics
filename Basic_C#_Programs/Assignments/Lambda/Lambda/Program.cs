using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{   
    // creating a struct that contains all items that make up an Employee
    public struct Employee
    {
        public int Id;
        public string firstName;
        public string lastName;

    }
    class Program
    {
        static void Main(string[] args)
        {

            //LAMBDA ASSIGNMENT 
            //================================

            // REFERENCE LINK: 
           //https://stackoverflow.com/questions/31430642/how-to-add-named-objects-to-a-list-when-declaring-the-list-c-sharp
            // creating a list of employees with:
            // firstName, lastName, and id
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Id = 0, firstName = "Bob", lastName = "Parker"},
                new Employee() {Id = 1, firstName = "Sheryl", lastName = "Copper"},
                new Employee() {Id = 2, firstName = "Joe", lastName = "Lambda"},
                new Employee() {Id = 3, firstName = "Joe", lastName = "Struct"},
                new Employee() {Id = 4, firstName = "Joe", lastName = "Scope"},
                new Employee() {Id = 5, firstName = "Jason", lastName = "Derulo"},
                new Employee() {Id = 6, firstName = "Keyshia", lastName = "Cole"},
                new Employee() {Id = 7, firstName = "Trish", lastName = "Stratus"},
                new Employee() {Id = 8, firstName = "Charlotte", lastName = "Flair"},
                new Employee() {Id = 9, firstName = "Aelita", lastName = "Stones"}
            };

            
            Console.WriteLine("These employees have a great work ethic: \n");
            // creating an empty list of type object "Employee"
            List<Employee> hardWorkers = new List<Employee>();
            // creating a foreach loop that adds all employees with first name "Joe" to new list
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe") // checks if first name = "Joe"
                {
                    hardWorkers.Add(employee); // adds item to new list
                    // prints each full name with the first name of "Joe"
                    Console.WriteLine(employee.firstName + " " + employee.lastName);
                }
            }

            Console.WriteLine("\n\nThese employees are always on time: \n");
            // creating a list of data type "Employee" that uses a lambda "=>" function "Where()"
            // to iterate through the "employees" list and adds all items with first name "Joe"
            List<Employee> onTimers = employees.Where(x => x.firstName == "Joe").ToList();
            // using a foreach loop to print all names in the console that match
            foreach (Employee onTimer in onTimers)
            {
                Console.WriteLine(onTimer.firstName + " " + onTimer.lastName);
            }

            Console.WriteLine("\n\nSuch a shame we promote by time of hire.\nHere are our new promoters: \n");
            // creating a new list "gotPromoted" using "Where()" labmda function to iterate through
            // "employees" list and add all items that have an Id greater than 5
            List<Employee> gotPromoted = employees.Where(x => x.Id > 5).ToList();
            // foreach loop that prints all items in new list to console.
            foreach (Employee promoter in gotPromoted)
            {
                Console.WriteLine("{0} {1}", promoter.firstName, promoter.lastName);
            }
            Console.WriteLine("\n\nCongrats for being our most recent hires!");
            Console.Read();
            

            
        }

    }
}
