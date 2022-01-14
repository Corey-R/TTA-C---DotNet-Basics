using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    public class Equation
    {
        // creating a void method that takes two integer parameters
        public void Multiply( int number, out int display)
        {            
            // performing math operation on first integer
            int x = number * 200;
            // passing a value to second integer
            // NOTE: "out int variableName" must be present in both defining and calling the method
            display = 17;
        }
    }
}
