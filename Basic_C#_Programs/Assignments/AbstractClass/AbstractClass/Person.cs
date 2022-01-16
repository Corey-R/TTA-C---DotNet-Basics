using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person // making class abstract
    {
        // creating two string properties "firstName" and "lastName" for later use
        public string firstName { get; set; }
        public string lastName { get; set; }

        // creating a virtual method that can be overridden by an inheriting class
        public virtual void SayName()
        {
            // implementation will be performed on this method in the inheriting class..
        }
    }
}
