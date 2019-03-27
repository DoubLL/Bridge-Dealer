namespace Bridge
{
    class FormatProvider
    {
        public static string Start(string description)
        {
            return $"DOCTYPE: BDL 11.4\r\n.description.deu = \"{description}\"\r\n";
        }
        public static string Format(Game game)
        {
            var result = $"\r\n\r\nSpiel        :   {game.number.ToString().PadLeft(2, '0')}\r\n";
            result += $"Teiler       :   {game.dealer.ToString()}\r\n";
            result += $"Gefahr       :   ---  \r\n";
            result += $"Karten       :                  {game.north.getClubs()}\r\n";
            result += $"             :                  {game.north.getDiamonds()}\r\n";
            result += $"             :                  {game.north.getHearts()}\r\n";
            result += $"             :                  {game.north.getSpades()}\r\n";
            result += $"             :   {game.west.getClubs().PadRight(30)}{game.east.getClubs()}\r\n";
            result += $"             :   {game.west.getDiamonds().PadRight(30)}{game.east.getDiamonds()}\r\n";
            result += $"             :   {game.west.getHearts().PadRight(30)}{game.east.getHearts()}\r\n";
            result += $"             :   {game.west.getSpades().PadRight(30)}{game.east.getSpades()}\r\n";
            result += $"             :                  {game.south.getClubs()}\r\n";
            result += $"             :                  {game.south.getDiamonds()}\r\n";
            result += $"             :                  {game.south.getHearts()}\r\n";
            result += $"             :                  {game.south.getSpades()}";
            return result;
        }
    }
}
