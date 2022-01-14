using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Operation
    {
        // creating method that passes in an integer
        public int Math(int number)
        {
            // storing results in int variable "added"
            int added = number + 30;
            return added; // returning results to whoever called it
        }
        // creating method with same name but different parameter 
        public int Math(decimal number)
        {
            int multiplied = Convert.ToInt32(number) * 10;
            return multiplied;
        }
        // same name method, different parameter
        public int Math(string number)
        {
            int subtracted = Convert.ToInt32(number) - 100;
            return subtracted;
        }
    }
}
