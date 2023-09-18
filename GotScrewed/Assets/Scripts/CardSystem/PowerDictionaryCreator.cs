using PlasticPipe.PlasticProtocol.Messages;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public static class PowerDictionaryCreator
{
    public static PowerDictionary CreateTrucoMineiroDictionary()
    {
        PowerDictionary pDictionary = new PowerDictionary();

        string[] values = { "4", "5", "6", "7", "J", "Q", "K", "A", "2", "3" };
        string[] suits = { "clubs", "hearts", "spades", "diamonds" };
        string[] manilhas = { "4.clubs", "7.hearts", "A.spades", "7.diamonds" };

        var manilhasDic = new Dictionary<string, int>()
        {
            { "4.clubs", 14},
            { "7.hearts", 13},
            { "A.spades", 12},
            { "7.diamonds", 11},
        };

        var regularDic = new Dictionary<string, int>()
        {
            {"3", 10},
            {"2", 9},
            {"A", 8},
            {"K", 7},
            {"Q", 6},
            {"J", 5},
            {"7", 4},
            {"6", 3},
            {"5", 2},
            {"4", 1},
        };

        foreach(string v in values)
        {
            foreach(string s in suits)
            {
                var cardName = v + "." + s;

                if(manilhas.Contains(cardName))
                {
                    pDictionary.SetValue(cardName, manilhasDic[cardName]);
                }

                else
                {
                    pDictionary.SetValue(cardName, regularDic[v]);
                }
            }
        }

        return pDictionary;
    }


    public static PowerDictionary CreateBasicDeckDictionary()
    {
        PowerDictionary pDictionary = new PowerDictionary();

        string[] values = { "2", "3", "4", "5", "6", "7", "J", "Q", "K", "A" };
        string[] suits = { "clubs", "hearts", "spades", "diamonds" };

        var regularDic = new Dictionary<string, int>()
        {            
            {"A", 11},
            {"K", 10},
            {"Q", 9},
            {"J", 8},
            {"7", 7},
            {"6", 6},
            {"5", 5},
            {"4", 4},
            {"3", 3},
            {"2", 2},
        };

        foreach(string v in values)
        {
            foreach(string s in suits)
            {
                var cardName = v + "." + s;
                pDictionary.SetValue(cardName, regularDic[v]);
            }
        }

        return pDictionary;
    }


    public static PowerDictionary CreateFourCardsDeck()
    {
        PowerDictionary pDictionary = new PowerDictionary();

        string[] values = { "A", "2", "3", "4" };
        string suit = "hearts";

        int i = 1;
        foreach (var v in values)
        {
            var cardName = v + "." + suit;
            pDictionary.SetValue(cardName, i);
            i++;    
        }
        

        return pDictionary;
    }
}
