using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Employee
    {
        // creating two properties "Id" and "Name"
        public int Id { get; set; }
        public string Name { get; set; }
    
    // defining overloaded == operator 
    // NOTE: In order to overload "==", you must have another comparison operator    
    public static bool operator ==(Employee employee, Employee employee1)
    {
        // returns boolean value "true or false" for the expression:
        // is employee's Id the same as employee1's Id
        return employee.Id == employee1.Id;
    }
        // defining overload operator != to prevent errors
        public static bool operator !=(Employee employee, Employee employee1)
        {
            return employee.Id != employee1.Id;
        }
    }
        

}


