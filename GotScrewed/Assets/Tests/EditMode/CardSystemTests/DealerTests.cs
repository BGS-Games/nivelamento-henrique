using System.Collections;
using System.Collections.Generic;
using CardSystem;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class DealerTests
{
    [Test]
    public void Given_a_deck_and_number_of_cards_should_return_smaller_deck_with_drawn_cards()
    {
        PowerDictionary powerDictionary = PowerDictionaryCreator.CreateTrucoMineiroDictionary();

        RegularDeck deck = new RegularDeck(powerDictionary);

        RegularDeck shorterDeck = new (Dealer.DealXCards(deck, 10));

        Assert.That(deck.CardList.Count, Is.EqualTo(30));
        Assert.That(shorterDeck.CardList.Count, Is.EqualTo(10));
    }

    [Test]
    public void Given_a_deck_should_distribute_X_number_of_cards_in_Y_piles()
    {
        PowerDictionary powerDictionary = PowerDictionaryCreator.CreateTrucoMineiroDictionary();

        RegularDeck deck = new RegularDeck(powerDictionary);

        int numCards = 5;
        int numPiles = 4;

        List<ICard>[] hands = Dealer.DealXCardsYPiles(deck, numCards, numPiles);

        foreach(List<ICard> hand in hands)
        {
            Assert.That(hand.Count, Is.EqualTo(numCards));
        }
    }
}
