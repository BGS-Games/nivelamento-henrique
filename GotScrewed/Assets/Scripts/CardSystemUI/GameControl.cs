using CardSystemUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CardSystem;
using CommonUse;
using System;
using System.IO;
using UnityFoundation.Code;
using TMPro;

namespace CardSystemUI
{
    //TODO: QUEBRAR PARTE DESSE C�DIGO EM DOIS - UM PRA CADA TELA
    public class GameControl : Singleton<GameControl>
    {     
        public GameObject menuMainPanel;
        
        [Header("DrawCardsPanels")]
        public GameObject drawCardsMainPanel;
        public GameObject drawCardsDeckPanel;
        public GameObject drawnCardsPanel;

        [Header("Counters")]
        public GameObject drawCardsDeckCounter;
        public GameObject drawCardsListCounter;

        [Header("DistributeCardsPanels")]
        public GameObject distributeCardsMainPanel;        
        public GameObject distributeCardsDeckPanel;
        
        [Header("OtherObjects")]
        public GameObject deckPanel;
        public GameObject cardPrefab;
        public Sprite deckBackCardSprite; 

        private RegularDeck currentDeck;
        private readonly List<ICard> drawnCardsList = new();


        private void UpdateDrawCardCounters()
        {
            drawCardsDeckCounter.GetComponent<TextMeshProUGUI>().text = currentDeck.ReturnNumberCards().ToString();
            drawCardsListCounter.GetComponent<TextMeshProUGUI>().text = drawnCardsList.Count.ToString();
        }

        public void StartGame()
        {            
            CreateDeck();

            SetMenus();

            InstantiateAllCardsFromDeck();
        }

        private void CreateDeck()
        {
            currentDeck = new(PowerDictionaryCreator.CreateDic(MenuControl.Instance.GetDeckType()));
        }

        private void SetMenus()
        {
            GeneralMethods.DeactivateMenuAnimateY(menuMainPanel, 1100);
            
            CallActionMenu();

        }

        private void CallActionMenu()
        {
            GameObject obj = drawCardsMainPanel;
            deckPanel = drawCardsDeckPanel;

            if(PlayerPrefs.GetInt("ActionType") == 1)
            {
                obj = distributeCardsMainPanel;
                deckPanel = distributeCardsDeckPanel;
            }

            GeneralMethods.ActivateMenuAnimateX(obj, 0);

            UpdateDrawCardCounters();
        }            

        public void DrawButton()
        {            
            ICard drawnCard = currentDeck.DrawCards(1)[0];
                        
            drawnCardsList.Add(drawnCard);
                        
            InstatiateCardObject(drawnCard, drawnCardsPanel, true);
                        
            InstantiateAllCardsFromDeck();

            UpdateDrawCardCounters();
        }

        //TODO: TALVEZ ESSAS DUAS FUN��ES DEVERIAM FAZER PARTE DO DEALER
        private void InstantiateAllCardsFromDeck()
        {
            GeneralMethods.CleanPanel(deckPanel);

            foreach (ICard c in currentDeck.CardList)
            {
                InstatiateCardObject(c, deckPanel, false);
            }
        }

        private void InstatiateCardObject(ICard c, GameObject panel, bool isUp)
        {
            GameObject newCard = Instantiate(cardPrefab);
            newCard.transform.SetParent(panel.transform);
            newCard.GetComponent<CardData>().SetCardData(c);
            newCard.name = newCard.GetComponent<CardData>().ReturnName();
            
            if (isUp)
            {
                newCard.GetComponent<CardData>().UpdateFaceSide();
            }           

        }
    }
}