namespace DamageSystem.Character
{
    public struct CharacterAttributes
    {
        public CharacterAttributes(string name, int health, int defense, int attack)
        {
            Name = name;
            Health = health;
            Defense = defense;
            Attack = attack;
        }

        public string Name { get; }
        public int Health { get; }
        public int Defense { get; }
        public int Attack { get; }
    }
}