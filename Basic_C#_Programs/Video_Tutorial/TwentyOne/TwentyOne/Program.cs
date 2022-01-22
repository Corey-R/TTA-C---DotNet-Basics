using System;
using Casino1;
using Casino1.TwentyOne;
using System.IO;

namespace TwentyOne
{
    class Program
    {


        // methods include:
        // access modifier (public), static if there is no instance of the class (static), 
        // return type (void = return nothing), name of method (Main()), and parameters if needed




        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}, would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Corey Reid\Documents\GitHub\TTA-CSharp--DotNet-Basics\Basic_C#_Programs\Logs\Log.txt", true))
                {
                    file.WriteLine(player.Id);                   
                }
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }            
       
    }
}
