using CardSystem;
using CommonUse;
using UnityEngine;

namespace CardSystemUI
{
    public static class DealerUI
    {
        public static void InstantiateAllCardsFromDeck(GameObject preFab, GameObject panel, IDeck deck)
        {
            GeneralMethods.CleanPanel(panel);

            foreach(ICard c in deck.CardList)
            {
                InstatiateCardObject(preFab, c, panel, false);
            }
        }

        public static void InstatiateCardObject(GameObject preFab, ICard c, GameObject panel, bool isUp)
        {
            GameObject newCard = UnityEngine.Object.Instantiate(preFab);
            newCard.transform.SetParent(panel.transform);
            newCard.GetComponent<CardData>().SetCardData(c);
            newCard.name = newCard.GetComponent<CardData>().ReturnName();

            if(isUp)
            {
                newCard.GetComponent<CardData>().UpdateFaceSide();
            }
        }
    }
}