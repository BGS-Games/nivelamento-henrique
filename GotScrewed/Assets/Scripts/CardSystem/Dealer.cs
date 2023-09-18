using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardSystem
{
    public static class Dealer
    {
        public static List<ICard> DealXCards(IDeck deck, int x)
        {
            return deck.DrawCards(x);
        }

        public static List<ICard>[] DealXCardsYPiles(IDeck deck, int numCards, int numPiles)
        {
            List<ICard>[] pilesArray = new List<ICard>[numPiles];
            
            for (int i = 0; i < numPiles; i++)
            {
                pilesArray[i] = deck.DrawCards(numCards);
            }

            return pilesArray;
        }
    }
}