using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardSystem
{
    public class Dealer
    {
        public IDeck DealXCards(IDeck deck, int x)
        {
            RegularDeck newDeck = new(deck.DrawCards(x));

            return newDeck;
        }
    }
}