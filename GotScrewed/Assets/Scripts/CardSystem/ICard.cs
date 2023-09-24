namespace CardSystem
{
    public interface ICard
    {       

        string Value { get; set; }

        int Power { get; set; }

        string Suit { get; set; }  

        string ImageAdress { get; set; }

        bool IsUp { get; set; }

        void UpdateFaceSide();

        public void PrintCard();
    }
}