using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino1
{
    // NOTE: .NET Framework only allows a class to inherit from only ONE class
    // This is where interfaces come into play.
    // You can inherit as many interfaces as you want 
    interface IWalkAway
    {
        // NOTE: everything will automatically be public with interfaces 
        void WalkAway(Player player);
    }
}
