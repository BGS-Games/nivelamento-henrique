using CardSystemUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CardSystem;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;

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
        RegularDeck currentDeck = new(PowerDictionaryCreator.CreateDic(type));
        //TODO create objects with the number of cards in the deck

        if (PlayerPrefs.GetInt("ActionType") == 0)
        {
            GeneralMethods.ActivateDrawCardMenu();
        }
        else
        {
            GeneralMethods.ActivateDealCardsMenu();
        }
    }
}
