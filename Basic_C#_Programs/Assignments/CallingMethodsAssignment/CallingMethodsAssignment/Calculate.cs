using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Calculate
    {    
        // creating 3 methods
        // each method takes in the user's number and returns the results as an integer
        public int Add(int userNumber)
        {
            int addNumber = 20 + userNumber;
            return addNumber;
        }
        public int Multiply(int userNumber)
        {
            int multiplyNumber = userNumber * 5;
            return multiplyNumber;
        }
        public int Subtract(int userNumber)
        {
            int result = userNumber - 10;
            return result;
        }

    }              
}
