using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardSystem
{
    public static class Dealer
    {
        public static IDeck DealXCards(IDeck deck, int x)
        {
            RegularDeck newDeck = new(deck.DrawCards(x));

            return newDeck;
        }

        public static IDeck[] DealXCardsYPiles(IDeck deck, int numCards, int numPiles)
        {
            RegularDeck[] multipleDecks = new RegularDeck[numPiles];

            for (int i = 0; i < numPiles; i++)
            {
                multipleDecks[i] = new(deck.DrawCards(numCards));
            }

            return multipleDecks;
        }
    }
}