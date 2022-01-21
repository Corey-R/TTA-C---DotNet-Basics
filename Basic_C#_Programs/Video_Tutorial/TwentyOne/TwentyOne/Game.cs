using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set{_players = value; } }
        public string Name { get; set; }
        public string Dealer { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }


        public abstract void Play();

        // the virtual method inside of an abstract class allows implementation
        // in the abstract class while also allowing the deriving class (the class that inherits this 
        // one) to override the virtual method.
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
