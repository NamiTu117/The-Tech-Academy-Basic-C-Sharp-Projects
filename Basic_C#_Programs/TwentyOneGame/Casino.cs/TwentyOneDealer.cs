using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    //inherits dealer 
    public class TwentyOneDealer : Dealer
    {
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public bool Stay { get; set; } //to not go over 21
        public bool isBusted { get; set; } //when going over 21

        internal void Deal(List<Card> hand)
        {
            throw new NotImplementedException();
        }
    }
}
