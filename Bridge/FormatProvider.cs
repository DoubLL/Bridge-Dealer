namespace Bridge
{
    class FormatProvider
    {
        public static string Start(string description)
        {
            return $"DOCTYPE: BDL 11.4\n.description.deu = \"{description}\"\n";
        }
        public static string Format(Game game)
        {
            var result = $"\n\nSpiel        :   {game.number.ToString().PadLeft(2, '0')}\n";
            result += $"Teiler       :   {game.dealer.ToString()}\n";
            result += $"Gefahr       :   ---  \n";
            result += $"Karten       :                  {game.north.getClubs()}\n";
            result += $"             :                  {game.north.getDiamonds()}\n";
            result += $"             :                  {game.north.getHearts()}\n";
            result += $"             :                  {game.north.getSpades()}\n";
            result += $"             :   {game.west.getClubs().PadRight(30)}{game.east.getClubs()}\n";
            result += $"             :   {game.west.getDiamonds().PadRight(30)}{game.east.getDiamonds()}\n";
            result += $"             :   {game.west.getHearts().PadRight(30)}{game.east.getHearts()}\n";
            result += $"             :   {game.west.getSpades().PadRight(30)}{game.east.getSpades()}\n";
            result += $"             :                  {game.south.getClubs()}\n";
            result += $"             :                  {game.south.getDiamonds()}\n";
            result += $"             :                  {game.south.getHearts()}\n";
            result += $"             :                  {game.south.getSpades()}";
            return result;
        }
    }
}
