using System.Xml.Linq;

namespace CardSystem
{
    public readonly struct CardInfo
    {
        public CardInfo(string value, int power, string suit, string deckType)
        {
            Value = value;
            Power = power;
            Suit = suit;
            DeckType = deckType;
        }


        public string Value{ get; }
        public int Power { get; }
        public string Suit { get; }

        public string DeckType { get; }

        
    }
}