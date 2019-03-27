using System;
using System.Collections.Generic;

namespace Bridge
{
    class GameProvider
    {
        private static Random random = new Random();

        public static Game createGame(uint i)
        {
            var hands = createHands();
            return new Game
            {
                number = i + 1,
                dealer = (Dealer) (i % 4),
                north = hands[0],
                east = hands[1],
                south = hands[2],
                west = hands[3],
            };
        }

        private static Hand[] createHands()
        {
            var hands = new Hand[4] { new Hand(), new Hand(), new Hand(), new Hand()};
            var deck = Card.getDeck();
            for (int i = 0; deck.Count > 0; i = (i + 1) % 4)
            {
                var card = deck[random.Next(deck.Count)];
                hands[i].cards.Add(card);
                deck.Remove(card);
            }
            foreach (var hand in hands)
                hand.cards.Sort(new CardComparer());
            return hands;
        }
    }
    class CardComparer : IComparer<Card>
    {
        private readonly string values = "23456789ZBDKA";
        public int Compare(Card x, Card y)
        {
            if (values.IndexOf(x.Value) > values.IndexOf(y.Value))
                return -1;
            if (values.IndexOf(x.Value) < values.IndexOf(y.Value))
                return 1;
            return 0;
        }
    }

}
