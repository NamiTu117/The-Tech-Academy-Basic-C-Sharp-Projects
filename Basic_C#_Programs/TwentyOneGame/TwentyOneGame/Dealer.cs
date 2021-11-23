using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOneGame
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }


        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            //using (StreamWriter file = new StreamWriter(@"E:\GitHubs\The-Tech-Academy-Basic-C-Sharp-Projects\Basic_C#_Programs", true))
            //{
            //    file.WriteLine(card);
            //}

            Deck.Cards.RemoveAt(0);
        }
    }
}
