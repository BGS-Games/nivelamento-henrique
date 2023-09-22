using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CardSystem;
using System;
using Unity.UI;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

namespace CardSystemUI
{
    public class MenuControl : MonoBehaviour
    {
        public static MenuControl instance;

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

        [Header("MainInfo")]
        public string deckType;
        public string actionType;
        public int numCards;
        public int numPlayers; 

        [Header("Objects")]
        public GameObject sliderNumCards;
        public GameObject sliderNumCardsTMP;
        public GameObject sliderNumPlayers;
        public GameObject sliderNumPlayersTMP;
        public GameObject deckImage;
        
        void Start()
        {
            sliderNumCards.GetComponent<Slider>().interactable = false;
            sliderNumPlayers.GetComponent<Slider>().interactable = false;

            numCards = 1;
            numPlayers = 1;

            PlayerPrefs.SetInt("DeckType", 0);
            PlayerPrefs.SetInt("ActionType", 0);
        }

        void Update()
        {
            deckType = GetDeckType();
            actionType = GetActionType();

            UpdateSlidersTmp();
        }

        private void UpdateSlidersTmp()
        {
            sliderNumCardsTMP.GetComponent<TextMeshProUGUI>().text = numCards.ToString() + " card(s).";
            sliderNumPlayersTMP.GetComponent<TextMeshProUGUI>().text = numPlayers.ToString() + " player(s).";
        }

        public void UpdateNumCards(GameObject slider)
        {
            numCards = (int) slider.GetComponent<Slider>().value;
        }

        public void UpdateNumPlayers(GameObject slider)
        {
            numPlayers = (int)slider.GetComponent<Slider>().value; 
        }

        private string GetDeckType()
        {
            var type = PlayerPrefs.GetInt("DeckType");            

            if (type == 1)
            {
                return "TrucoMineiro";
            }
            else if (type == 2)
            {
                return "Hanabi";
            }
            else if (type == 3)
            {
                return "TheMind";
            }

            return "TraditionalDeck";
        }

        private string GetActionType()
        {
            var type = PlayerPrefs.GetInt("ActionType");

            if(type == 1)
            {
                return "DealCard";
            }

            return "DrawCard";
        }

        public void UpdateDeckGroupToggle(int value)
        {
            PlayerPrefs.SetInt("DeckType", value);
            UpdateDeckImage();
        }

        private void UpdateDeckImage()
        {
            string path = "Images/" + GetDeckType() + "Icon";
            deckImage.GetComponent<Image>().sprite = Resources.Load<Sprite>(path);
        }

        public void UpdateActionGroupToggle(int value)
        {
            PlayerPrefs.SetInt("ActionType", value);
            UpdateSliders();
        }

        private void UpdateSliders()
        {
            if (PlayerPrefs.GetInt("ActionType") == 1)
            {
                sliderNumCards.GetComponent<Slider>().interactable = true;
                sliderNumPlayers.GetComponent<Slider>().interactable = true;
            }
            else
            {
                sliderNumCards.GetComponent<Slider>().interactable = false;
                sliderNumPlayers.GetComponent<Slider>().interactable = false;
            }            
        }

        public void ButtonPlay()
        {
            GameControl.instance.StartGame(deckType);
        }
    }
}