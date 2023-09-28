using CardSystem;
using CommonUse;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityFoundation.Code;

namespace CardSystemUI
{
    public class DrawCardMenuControl : Singleton<DrawCardMenuControl>
    {
        [Header("DrawCardsPanels")]
        public GameObject mainPanel;

        public GameObject deckPanel;
        public GameObject drawnCardsPanel;

        [Header("Counters")]
        public GameObject deckCounter;

        public GameObject drawnCardsCounter;

        [Header("OtherObjects")]
        public GameObject cardPrefab;

        public Sprite deckBackCardSprite;

        private RegularDeck currentDeck;
        private readonly List<ICard> drawnCardsList = new();

        public void InitializeMenu()
        {
            GeneralMethods.ActivateMenuAnimateX(mainPanel, 0);
            CreateDeck();
            DealerUI.InstantiateAllCardsFromDeck(cardPrefab, deckPanel, currentDeck);
            UpdateDrawCardCounters();
        }

        private void UpdateDrawCardCounters()
        {
            deckCounter.GetComponent<TextMeshProUGUI>().text = currentDeck.ReturnNumberCards().ToString();
            drawnCardsCounter.GetComponent<TextMeshProUGUI>().text = drawnCardsList.Count.ToString();
        }

        private void CreateDeck()
        {
            currentDeck = new(PowerDictionaryCreator.CreateDic(MenuControl.Instance.GetDeckType()));
        }

        public void DrawButton()
        {
            ICard drawnCard = currentDeck.DrawCards(1)[0];

            drawnCardsList.Add(drawnCard);

            DealerUI.InstatiateCardObject(cardPrefab, drawnCard, drawnCardsPanel, true);

            DealerUI.InstantiateAllCardsFromDeck(cardPrefab, deckPanel, currentDeck);

            UpdateDrawCardCounters();
        }
    }
}