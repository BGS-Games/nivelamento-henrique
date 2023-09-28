using System.Collections.Generic;

namespace CardSystem
{
    public interface IDeck
    {
        public string Type { get; }

        List<ICard> CardList { get; }

        public void PrintCards();

        public void ShuffleCards();

        public List<ICard> DrawCards(int x);
    }
}