using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Employee<T> // generic <T> type parameter 
    {
        // adding a property with generic list type named "Things"
        public List<T> Things { get; set; }

    }
}
