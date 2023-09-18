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
    }
}