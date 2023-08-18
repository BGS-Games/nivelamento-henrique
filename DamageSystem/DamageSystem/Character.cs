namespace DamageSystem
{

    public class Character
    {
        public string Name { get; }
        public int Defense { get; }
        public bool IsDead => Health == 0;
        public int Health { get; private set; }
        public int Equipment { get; set; }
        public int Attack { get; }

        public Character(CharacterAttributes attributes)
        {
            if(attributes.Health == 0) 
                throw new ArgumentException("Health should be greater than 0.");

            Name = attributes.Name;
            Health = attributes.Health;
            Defense = attributes.Defense;
            Attack = attributes.Attack; 
        }

        internal void TakeDamage(int damage)
        {
            Health -= damage;

            if (Health < 0) 
            { 
                Health = 0;
                Console.WriteLine(Name + " morreu.");
            }

            else
            {
                Console.WriteLine(Name + " tem uma vida restante de " + Health);
            }
            
        }
    }
}