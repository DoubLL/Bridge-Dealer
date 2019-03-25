using System;
using System.Collections.Generic;

namespace Bridge
{
    class GameProvider
    {
        public static List<Game> createGames(uint count)
        {
            var games = new List<Game>();
            for (uint i = 0; i < count; i++)
            {
                var hands = createHands();
                games.Add(new Game
                {
                    number = i + 1,
                    dealer = (Dealer) (i % 4),
                    north = hands[0],
                    east = hands[1],
                    south = hands[2],
                    west = hands[3],
                });
            }
            return games;
        }

        private static Hand[] createHands()
        {
            var hands = new Hand[4] { new Hand(), new Hand(), new Hand(), new Hand()};
            var deck = Card.getDeck();
            var rnd = new Random();
            for (int i = 0; deck.Count > 0; i = (i + 1) % 4)
            {
                var card = deck[rnd.Next(deck.Count)];
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
