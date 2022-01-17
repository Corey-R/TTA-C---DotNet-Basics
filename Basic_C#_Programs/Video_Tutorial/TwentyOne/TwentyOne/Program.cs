using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {        
        // methods include:
        // access modifier (public), static if there is no instance of the class (static), 
        // return type (void = return nothing), name of method (Main()), and parameters if needed




        static void Main(string[] args)
        {
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Jesse";
            game += player;
            game -= player;

            // instantiate a Deck of cards
            // Data Type "Deck" named Deck equals a new Deck() object
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.Read();
        }                     
    }
}
