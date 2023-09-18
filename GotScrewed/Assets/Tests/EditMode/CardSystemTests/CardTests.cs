using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using CardSystem;

namespace CardSystemTests
{
    public class CardTests
    {
        [Test]
        public void A_new_card_should_be_initialized_with_a_value()
        {
            RegularCard card = new("J");

            Assert.That(card.Value, Is.EqualTo("J"));
        }

        [Test]
        public void A_regular_card_should_be_initialized_with_a_power_and_a_suit()
        {
            CardInfo cardInfo = new("J", 11, "clubs");
                        
            RegularCard card = new (cardInfo);

            Assert.That(card.Power, Is.EqualTo(11));
            Assert.That(card.Suit, Is.EqualTo("clubs"));
        }
    }
}