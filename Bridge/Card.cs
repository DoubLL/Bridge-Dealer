using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Card
    {
        public Suit Suit { get; set; }
        public char Value { get; set; }
        public static readonly char[] Values = new char[] { '2', '3', '4', '5', '6', '7', '8', '9', 'Z', 'B', 'D', 'K', 'A' };

        public static List<Card> getDeck()
        {
            var cards = new List<Card>();
            var values = Values;
            var suits = new Suit[] { Suit.Club, Suit.Diamond, Suit.Heart, Suit.Spade };
            foreach (var suit in suits)
                foreach (var value in values)
                    cards.Add(new Card() { Suit = suit, Value = value });
            return cards;
        }
    }

    enum Suit
    {
        Club = 0,
        Diamond = 1,
        Heart = 2,
        Spade = 3
    }
}
