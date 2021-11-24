using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {

            //File
            //string text = "Here is some text.";         
            //File.ReadAllText(@"E:\GitHubs\The-Tech-Academy-Basic-C-Sharp-Projects\Basic_C#_Programs\log.txt");

            //Datetime year, month, day, hour, minute, second 
           // DateTime yearofBirth = new DateTime(1998, 2, 27, 1, 35, 00);

           // DateTime yearofGraduation = new DateTime(2016, 5, 16, 6, 00, 00);
            //TimeSpan ageatGraduation = yearofGraduation - yearofBirth;


            //Welcome Screen 
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name ");
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right!", playerName);
            string answer = Console.ReadLine().ToLower();


            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName , bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now");
            Console.Read();



        
        }

        

    }
        
    
}