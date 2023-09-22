using CardSystemUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CardSystem;
using CommonUse;

namespace CardSystemUI
{
    public class GameControl : MonoBehaviour
    {
        public static GameControl instance;

        public GameObject MenuMainPanel;
        public GameObject DrawCardsMainPanel;
        public GameObject DistributeCardsMainPanel;

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

        public void StartGame(string type)
        {
            //RegularDeck currentDeck = new(PowerDictionaryCreator.CreateDic(type));
            //TODO create objects with the number of cards in the deck

            GeneralMethods.DeactivateMenuAnimateY(MenuMainPanel, 1100);

            GameObject obj = DrawCardsMainPanel; 

            if(PlayerPrefs.GetInt("ActionType") == 1)
            {
                obj = DistributeCardsMainPanel;
            }

            GeneralMethods.ActivateMenuAnimateX(obj, 0);
        }
    }
}