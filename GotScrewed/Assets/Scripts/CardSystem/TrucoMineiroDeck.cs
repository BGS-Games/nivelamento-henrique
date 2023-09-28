using System.Collections.Generic;
using System.Linq;

public class TrucoMineiroDeck
{
    private readonly DeckCreator creator;

    public TrucoMineiroDeck(DeckCreator creator)
    {
        this.creator = creator;
    }

    public PowerDictionary Create()
    {

        creator.FromType("TrucoMineiro");
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
                    creator.AddCard(cardName, manilhasDic[cardName]);
                }
                else
                {
                    creator.AddCard(cardName, regularDic[v]);
                }
            }
        }

        return creator.Create();
    }
}