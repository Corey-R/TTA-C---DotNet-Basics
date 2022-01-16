using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE: TO REFERENCE OTHER PROJECTS IN ORDER TO INHERIT THIS INTERFACE
            // Click File > Add > Existing Project > Select "AbstractClass" 
            // In solution explorer, right-click "references" of AbstractClass project
            // > Add Reference > Check "Polymorphism" project > Click "Okay"
            // You should see "Polymorphism" in the list of AbstractClass's "References"
            
            // Once Complete:
            // Ensure to add "using Polymorphism" in the cs files that will use the IQuittable 
            // interface (in my case, AbstractClass.Program.cs, and AbstractClass.Employee.cs)
            // From there, in Employee.cs add IQuittable to Employee class:
            // public class Employee : Person, IQuittable 
            // Add Quit() method to Employee class with custom implementation
            
            // NOTE: Ensure you are in the AbstractClass project after adding Polymorphism as a 
            // reference, otherwise if you run while still in "Polymorphism", you will run the 
            // Polymorphism's Program.cs instead of the AbstractClass's program.cs which contains the 
            // code.

        }
    }
}
