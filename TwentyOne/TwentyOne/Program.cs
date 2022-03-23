using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INTRO
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did ytou bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0} would you like to play BlackJack?", playerName);
            string answer = Console.ReadLine().ToLower();
            //END OF INTRO

            if ( answer == "yes" || answer == "yea" || answer == "y" )
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Not Bad! Thank you for playing!");

            }
            Console.WriteLine("See you soon!");
            Console.ReadLine();

        }
    }
}
