using CardSystem;
using CommonUse;
using System.Collections.Generic;
using UnityEngine;
using UnityFoundation.Code;
using TMPro;
using System;

namespace CardSystemUI
{
    public class DistributeCardMenuControl : Singleton<DistributeCardMenuControl>
    {
        [Header("DistributeCardMenuAndPanels")]
        public GameObject mainPanel;
        public GameObject deckPanel;
        public GameObject handPanelPreFab;
        public GameObject otherPlayersPanel;        

        [Header("Counters")]
        public GameObject deckCounter;

        [Header("OtherObjects")]
        public GameObject cardPrefab;

        public Sprite deckBackCardSprite;

        private RegularDeck currentDeck;
        private List<ICard>[] handsArray;

        //public int numCards;
        //public int numPlayers;

        private void Start()
        {
            handsArray = new List<ICard>[MenuControl.Instance.numPlayers];
        }

        internal void InitializeMenu()
        {
            GeneralMethods.ActivateMenuAnimateX(mainPanel, 0);
            
            CreateDeck();
            
            DealerUI.InstantiateAllCardsFromDeck(cardPrefab, deckPanel, currentDeck);

            CreatePlayersHandPanel();

            UpdateDeckCardCounter();
        }

        private void CreatePlayersHandPanel()
        {
            int numberPanel = MenuControl.Instance.numPlayers - 1;

            for (int i = 0; i < numberPanel; i++) 
            {
                GameObject panel = UnityEngine.Object.Instantiate(handPanelPreFab);
                panel.transform.SetParent(otherPlayersPanel.transform);
                panel.name = "Player" + (i+1);
            }           

        }

        private void CreateDeck()
        {
            currentDeck = new(PowerDictionaryCreator.CreateDic(MenuControl.Instance.GetDeckType()));
        }

        private void UpdateDeckCardCounter()
        {
            deckCounter.GetComponent<TextMeshProUGUI>().text = 
                currentDeck.ReturnNumberCards().ToString();
        }

    }
}