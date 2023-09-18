namespace CardSystem
{
    public readonly struct CardInfo
    {
        public CardInfo(string value, int power, string suit)
        {
            Value = value;
            Power = power;
            Suit = suit;
        }


        public string Value{ get; }
        public int Power { get; }
        public string Suit { get; }

        
    }
}