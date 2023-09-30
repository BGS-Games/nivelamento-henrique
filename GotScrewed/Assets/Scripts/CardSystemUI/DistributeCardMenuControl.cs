using CardSystem;
using CommonUse;
using System.Collections.Generic;
using UnityEngine;
using UnityFoundation.Code;
using TMPro;
using System;
using UnityEngine.XR;
using System.IO.IsolatedStorage;

namespace CardSystemUI
{
    public class DistributeCardMenuControl : Singleton<DistributeCardMenuControl>
    {
        [Header("DistributeCardMenuAndPanels")]
        public GameObject mainPanel;
        public GameObject deckPanel;
        public GameObject mainPlayerHandPanel;
        public GameObject handPanelPreFab;
        public GameObject otherPlayersPanel;        

        [Header("Counters")]
        public GameObject deckCounter;

        [Header("OtherObjects")]
        public GameObject cardPrefab;

        public Sprite deckBackCardSprite;

        private RegularDeck currentDeck;
        private List<ICard>[] handsArray;

        private void Start()
        {
            handsArray = new List<ICard>[MenuControl.Instance.numPlayers];
        }

        internal void InitializeMenu()
        {
            GeneralMethods.ActivateMenuAnimateX(mainPanel, 0);
            
            CreateDeck();
            
            DealerUI.InstantiateAllCardsFromDeck(cardPrefab, deckPanel, currentDeck);

            int numPlayers = MenuControl.Instance.numPlayers;
            int numCards = MenuControl.Instance.numCards;

            handsArray = Dealer.DealXCardsYPiles(currentDeck, numCards, numPlayers);

            //plota as cartas do jogador principal
            CreateHand(handsArray[0], mainPlayerHandPanel, true);
            //Modifica o CreatePlayersHandPanel para plotar as cartas dos outros jogadores

            CreatePlayersHandPanel();

            UpdateDeckCardCounter();
        }

        private void CreateHand(List<ICard> hand, GameObject panel, bool isUp)
        {
            for(int i = 0; i < hand.Count; i++)
            {
                DealerUI.InstatiateCardObject(cardPrefab, hand[i], panel, isUp);
            }
        }


        private void CreatePlayersHandPanel()
        {
            int numberPanel = MenuControl.Instance.numPlayers - 1;

            for (int i = 0; i < numberPanel; i++) 
            {
                GameObject panel = UnityEngine.Object.Instantiate(handPanelPreFab);
                panel.transform.SetParent(otherPlayersPanel.transform);
                panel.name = "Player" + (i+1);

                CreateHand(handsArray[i+1], panel, false);
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

        public void ShowCardsButton()
        {
            var name = "Player";

            if (MenuControl.Instance.numPlayers > 1)
            {
                for (int i = 1;  i < MenuControl.Instance.numPlayers; i++)
                {
                    GameObject panel = GameObject.Find(name + i);

                    foreach(Transform child in panel.transform)
                    {
                        child.gameObject.GetComponent<CardData>().UpdateFaceSide();
                    }
                }
            }

            GameObject Txt = GameObject.Find("ShowHideTxt");
            
            if(Txt.GetComponent<TextMeshProUGUI>().text == "Show")
            { Txt.GetComponent<TextMeshProUGUI>().text = "Hide"; }
            else
            { Txt.GetComponent<TextMeshProUGUI>().text = "Show"; }
            
            
        }
    }
}