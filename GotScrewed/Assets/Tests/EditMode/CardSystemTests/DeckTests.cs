using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using CardSystem;

namespace CardSystemTests
{
    public class DeckTests
    {
        [Test]
        public void Given_two_arrays_with_suits_and_values_should_be_able_to_create_a_regular_deck()
        {
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] values = { "4", "5", "¨6", "7", "8", "9", "10", "J", "Q", "K", "A", "2", "3" };

            RegularDeck deck = new RegularDeck(suits, values);

            Assert.That(deck.CardList.Count, Is.EqualTo(52));
        }

        //[Test]
        public void Given_a_power_dictionary_should_be_able_to_create_deck_with_specif_card_powers()
        {            
            PowerDictionary powerDictionary = PowerDictionaryCreator.CreateTrucoMineiroDictionary();

            RegularDeck deck = new RegularDeck(powerDictionary);
        }

        
    }
}
