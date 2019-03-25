using System.Collections.Generic;
using System.Linq;

namespace Bridge
{
    class Hand
    {
        public List<Card> cards { get; } = new List<Card>();

        public string getClubs() => getString(Suit.Club);
        public string getDiamonds() => getString(Suit.Diamond);
        public string getHearts() => getString(Suit.Heart);
        public string getSpades() => getString(Suit.Spade);

        private string getString(Suit suit)
        {
            var cards = this.cards.Where(c => c.Suit == suit);
            if (cards.Count() == 0) return "- ";
            var res = "";
            foreach (var c in cards)
            {
                res += c.Value + " ";
            }
            return res;
        }
    }
}
