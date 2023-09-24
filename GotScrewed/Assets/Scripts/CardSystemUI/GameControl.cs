using CardSystemUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CardSystem;
using CommonUse;
using System;
using System.IO;

namespace CardSystemUI
{
    public class GameControl : MonoBehaviour
    {
        public static GameControl instance;

        public GameObject menuMainPanel;        

        public GameObject drawCardsMainPanel;
        public GameObject drawCardsDeckPanel;
        
        public GameObject distributeCardsMainPanel;        
        public GameObject distributeCardsDeckPanel;

        public GameObject deckPanel;

        public GameObject cardPrefab;
        public Sprite deckBackCardSprite; 

        private RegularDeck currentDeck;        

        // Initialize the class as an instance 
        void Awake()
        {
            if(instance == null)
            {
                instance = this;
            }
            else if(instance != this)
            {
                Destroy(gameObject);
            }
        }

        public void StartGame()
        {            
            CreateDeck();

            SetMenus();

            InstantiateAllCardsFromDeck();
        }

        private void CreateDeck()
        {
            currentDeck = new(PowerDictionaryCreator.CreateDic(MenuControl.instance.GetDeckType()));
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
        }            

        //TODO: TALVEZ ESSAS DUAS FUNÇÕES DEVERIAM FAZER PARTE DO DEALER
        private void InstantiateAllCardsFromDeck()
        {
            foreach (ICard c in currentDeck.CardList)
            {
                InstatiateCardObject(c);
            }
        }

        private void InstatiateCardObject(ICard c)
        {
            GameObject newCard = Instantiate(cardPrefab);
            newCard.transform.SetParent(deckPanel.transform);
            newCard.GetComponent<CardData>().SetCardData(c);
            newCard.name = newCard.GetComponent<CardData>().ReturnName();
            ////newCard.GetComponent<Image>().sprite = Resources.Load<Sprite>(c.ImageAdress);

        }
    }
}