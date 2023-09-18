namespace CardSystem
{
    public class RegularCard : ICard
    {
        public string Value { get; }
        public int Power { get; }
        public string Suit { get; }

        public RegularCard(string name)
        {
            Value = name;
            Power = 0;
        }

        public RegularCard(string name, int value, string suit)
        {
            Value = name;
            Power = value;
            Suit = suit;
        }

        public RegularCard (CardInfo cardinfo)
        {
            Value = cardinfo.Value;
            Power = cardinfo.Power;
            Suit = cardinfo.Suit;
        }
    }
}
