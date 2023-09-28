public class DeckCreator
{
    PowerDictionary dict;

    public DeckCreator FromType(string type)
    {
        dict = new(type);
        return this;
    }

    public DeckCreator AddCard(string cardName, int value)
    {
        dict.SetValue(cardName, value);
        return this;
    }

    public PowerDictionary Create()
    {
        return dict;
    }
}
