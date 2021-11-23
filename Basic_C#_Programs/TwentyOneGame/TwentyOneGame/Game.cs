using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public abstract class Game
    {
        //setting properties
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }             
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
        

        public abstract void Play();

        //method
        //virtual method: method is inherited by inheriting class
        //but has the ability to override it 
        public virtual void ListPlayers()
        {
            //foreach sets the number of Players in a game 
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
