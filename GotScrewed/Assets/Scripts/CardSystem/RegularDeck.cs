using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

namespace CardSystem
{
    public class RegularDeck : IDeck
    {
        private readonly List<ICard> cardList;
        public List<ICard> CardList { get => cardList; }

        public RegularDeck(string[] suits, string[] values)
        {
            cardList = new();

            int i = 0;
            foreach (string s in suits)
            {
                foreach (string v in values)
                {
                    CardInfo newCard = new(v, i++, s);
                    cardList.Add(new RegularCard(newCard));
                }
            }
        }

        public RegularDeck (List<ICard> cardList)
        {
            this.cardList = cardList;
        }   

        public RegularDeck(PowerDictionary powerDictionary)
        {
            cardList = new();

            string value;
            string suit;
            int power; 

            foreach (KeyValuePair<string, int> entry in powerDictionary.GetPowerDic())
            {
                string[] s = entry.Key.Split('.');
                value = s[0];
                suit = s[1];
                power = entry.Value;

                CardInfo newCard = new(value, power, suit);
                cardList.Add(new RegularCard(newCard));
            }
        }

        public ICard DrawCardRandomly()
        {
            int drawnNumber = UnityEngine.Random.Range(0, cardList.Count-1);
            return cardList[drawnNumber];
        }

        public void PrintCards()
        {
            foreach (ICard c in cardList)
            {                
                c.PrintCard();
            }
        }

        public void ShuffleCards()
        {
            System.Random random = new();
            int n = cardList.Count;
            while ( n > 1 )
            {
                int k = random.Next(n);
                n--;
                (cardList[n], cardList[k]) = (cardList[k], cardList[n]);
            }
        }

        public List<ICard> DrawCards(int x)
        {
            List<ICard> cards;
            
            cards = CardList.GetRange(0, x);
            
            CardList.RemoveRange(0, x);
            
            return cards;
        }
    }
}