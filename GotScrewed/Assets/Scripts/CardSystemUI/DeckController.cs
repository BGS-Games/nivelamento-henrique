using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CardSystem;
using System;
using Unity.UI;
using UnityEngine.UI;
using UnityEditor;

namespace CardSystemUI
{
    public class DeckController : MonoBehaviour
    {
        public static DeckController instance;

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

        [Header("Objects")]
        public GameObject sliderNumCards;
        public GameObject sliderNumPlayers;
        public GameObject deckImage;
        

        void Start()
        {
            sliderNumCards.GetComponent<Slider>().interactable = false;
            sliderNumPlayers.GetComponent<Slider>().interactable = false;

            PlayerPrefs.SetInt("DeckType", 0);
            PlayerPrefs.SetInt("ActionType", 0);
        }

        void Update()
        {
            deckType = GetDeckType();
            actionType = GetActionType();
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
    }
}