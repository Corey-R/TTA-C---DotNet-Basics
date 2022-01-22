using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
    public class Names
    {
        // defining Constructor Chain that only takes one string value
        public Names(string fName) : this(fName, "X") // inheriting constructor with two string values
        {
            // inherits the implementation from the below constructor...
        }
        // defining constructor that takes 2 string values
        public Names(string fName, string lName)
        {
            FirstName = fName; // stores fName value in "FirstName" property
            LastName = lName; // stores lName value in "LastName" property
            FullName = fName + " " + lName; // combines first and last name with space provided
        }
        // Defines the properties used in above constructors
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
    }
}
