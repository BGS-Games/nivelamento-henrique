namespace DamageSystem
{
    public struct CharacterAttributes
    {
        public CharacterAttributes(int health, int defense, int attack)
        {
            Health = health;
            Defense = defense;
            Attack = attack;
        }

        public int Health { get; }
        public int Defense { get; }        
        public int Attack { get; }
    }
}