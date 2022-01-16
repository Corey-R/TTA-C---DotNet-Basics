using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person // inheriting from Person class
    {
        // NOTE: Inheriting the class inherits all class members and methods associated with it
        // overriding the virtual method created in superClass "Person" for custom implementation
        public override void SayName()
        {
            // prints welcome message to console including user's full name
            Console.WriteLine("Welcome: [{0} {1}", firstName, lastName);
            // calls the original virtual method from abstract class.
            base.SayName();
        }
    }
}
