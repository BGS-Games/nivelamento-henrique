using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardSystem
{
    public interface IDeck
    {
        List<ICard> CardList { get; }

        public void PrintCards();

        public void ShuffleCards();

        public List<ICard> DrawCards(int x);
    }
}
