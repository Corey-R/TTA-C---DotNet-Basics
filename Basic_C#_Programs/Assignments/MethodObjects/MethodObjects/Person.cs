using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObjects
{
    public class Person
    {
        // creating two string properties 
        public string FirstName { get; set; }
        public string LastName  { get; set; }

        // void method called SayName()
        public void SayName()
        {
            // printing full name to console
            Console.WriteLine("Name: [{0} {1}]", FirstName, LastName);
        }
    }
}
