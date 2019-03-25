namespace Bridge
{
    class Game
    {
        public uint number { get; set; }
        public Dealer dealer { get; set; }
        public Hand north { get; set; }
        public Hand east { get; set; }
        public Hand south { get; set; }
        public Hand west { get; set; }
    }

    enum Dealer
    {
        Nord = 0,
        Ost = 1,
        Süd = 2,
        West = 3
    }
}
