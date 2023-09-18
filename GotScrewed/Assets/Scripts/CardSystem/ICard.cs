namespace CardSystem
{
    public interface ICard
    {
        string Value { get; }

        int Power { get; }

        public void PrintCard();
    }
}