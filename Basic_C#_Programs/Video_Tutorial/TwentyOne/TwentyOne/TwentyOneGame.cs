using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    // To inherit from a class just add a colon after the class name and enter the name of the 
    // inherited class
    public class TwentyOneGame : Game
    {
        // when inheriting from an abstract, you must used its abstract method
        // by adding "override" using the same name (Play) and return (void)
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }
    }
}
