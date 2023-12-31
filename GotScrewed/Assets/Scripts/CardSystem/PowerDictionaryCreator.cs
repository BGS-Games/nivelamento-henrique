using System.Collections.Generic;

public static class PowerDictionaryCreator
{
    public static PowerDictionary CreateDic(string type)
    {
        if(type == "TrucoMineiro")
        {
            return CreateTrucoMineiroDictionary("TrucoMineiro");
        }
        else if(type == "TheMind")
        {
            return CreateTheMindDeck("TheMind");
        }
        else if(type == "Hanabi")
        {
            return CreateHanabiDeck("Hanabi");
        }

        return CreateBasicDeckDictionary("TraditionalDeck");
    }

    public static PowerDictionary CreateTrucoMineiroDictionary(string type)
    {
        return new TrucoMineiroDeck(new DeckCreator()).Create();
    }

    public static PowerDictionary CreateBasicDeckDictionary(string type)
    {
        PowerDictionary pDictionary = new PowerDictionary(type);

        string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] suits = { "clubs", "hearts", "spades", "diamonds" };

        var regularDic = new Dictionary<string, int>()
        {
            {"A", 14},
            {"K", 13},
            {"Q", 12},
            {"J", 11},
            {"10", 10},
            {"9", 9},
            {"8", 8},
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

    public static PowerDictionary CreateFourCardsDeck(string type)
    {
        PowerDictionary pDictionary = new PowerDictionary(type);

        string[] values = { "A", "2", "3", "4" };
        string suit = "hearts";

        int i = 1;
        foreach(var v in values)
        {
            var cardName = v + "." + suit;
            pDictionary.SetValue(cardName, i);
            i++;
        }

        return pDictionary;
    }

    public static PowerDictionary CreateHanabiDeck(string type)
    {
        PowerDictionary pDictionary = new PowerDictionary(type);

        string[] values = { "1", "2", "3", "4", "5" };
        string[] suits = { "white", "red", "green", "blue", "yellow" };

        foreach(string value in values)
        {
            foreach(string suit in suits)
            {
                var cardName = value + "." + suit;
                pDictionary.SetValue(cardName, int.Parse(value));
            }
        }

        return pDictionary;
    }

    public static PowerDictionary CreateTheMindDeck(string type)
    {
        PowerDictionary pDictionary = new PowerDictionary(type);
        string suit = "no Suit";

        for(int i = 0; i < 100; i++)
        {
            var cardName = i.ToString() + "." + suit;
            pDictionary.SetValue(cardName, i);
        }

        return pDictionary;
    }
}
