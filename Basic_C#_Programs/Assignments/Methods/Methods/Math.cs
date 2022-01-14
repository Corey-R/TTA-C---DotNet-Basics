using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{    
    public class Math
    {
        // creating method containing a required parameter and optional parameter
        public int Add(int number, int numTimes = 1) // numTimes = 1 is the optional parameter
        {                       
            // performing basic order of operations PEMDAS (parenthesis first) then multiply
            int added = (number + 10) * numTimes;
            // return value
            return added;
        }
    }
}
