using System;
using System.Diagnostics;
using UnityEngine;

namespace CardSystem
{
    public class RegularCard : ICard
    {
        public string Value { get; set; }
        public int Power { get; set; }
        public string Suit { get; set; }
        public string ImageAdress { get; set; }       
        public bool IsUp { get; set;  }

        public RegularCard (CardInfo cardinfo)
        {
            Value = cardinfo.Value;
            Power = cardinfo.Power;
            Suit = cardinfo.Suit;
            IsUp = false;
            ImageAdress = "Images/" + cardinfo.DeckType + "/" + GetCardName();
        }

        public void PrintCard()
        {
            UnityEngine.Debug.Log($"{Value} de {Suit} com potência de {Power}");
        }      
  
        private string GetCardName()
        {
            return this.Value + "." + this.Suit;
        }

        public void UpdateFaceSide()
        {
            IsUp = !IsUp;
        }
    }
}
