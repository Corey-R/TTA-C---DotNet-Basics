using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
    public class Names
    {
        public Names(string fName) : this(fName, "X")
        {
        }
        public Names(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
            FullName = fName + " " + lName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
    }
}
