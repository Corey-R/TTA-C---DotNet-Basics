using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myProgram = "Corey's Constructor Chain Program";
            var exampleVariable = myProgram;
            Names name = new Names("Professor");
            Console.WriteLine("Welcome to {0} {1}!", exampleVariable, name.FullName);
            Console.Read();

                        
             


        }
    }
}
