using CardSystem;
using UnityEngine;
using UnityEngine.UI;

namespace CardSystemUI
{
    public class CardData : MonoBehaviour, ICard
    {
        public string Value { get; set; }

        public int Power { get; set; }

        public string Suit { get; set; }

        public string ImageAdress { get; set; }

        public bool IsUp { get; set; }

        public void SetCardData(ICard c)
        {
            Value = c.Value;
            Power = c.Power;
            ImageAdress = c.ImageAdress;
            IsUp = c.IsUp;
            Suit = c.Suit;
        }

        // Start is called before the first frame update
        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {
            if(IsUp)
            {
                gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(ImageAdress);
            }
        }

        public void PrintCard()
        {
            throw new System.NotImplementedException();
        }

        public string ReturnName()
        {
            return Value + "." + Suit;
        }

        public void UpdateFaceSide()
        {
            IsUp = !IsUp;
        }
    }
}