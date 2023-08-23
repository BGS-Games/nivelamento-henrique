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

        public DefenseInfo lastDefense { get; set; }

        public class DefenseInfo 
        {
            public int LastDamage { get; set; }
            public float LastReduction { get; set; }

            public DefenseInfo ()
            {
                LastDamage = 0;
                LastReduction = 0;
            }

            public void UpdateInfo(int lastDamage, float lastReduction)
            {
                LastDamage = lastDamage;
                LastReduction = lastReduction;
            }
        }

        public Character(CharacterAttributes attributes)
        {
            if(attributes.Health == 0) 
                throw new ArgumentException("Health should be greater than 0.");

            Name = attributes.Name;
            Health = attributes.Health;
            Defense = attributes.Defense;
            Attack = attributes.Attack;
            lastDefense = new DefenseInfo();
        }

        internal void TakeDamage(int damage, float reduction)
        {
            Health -= damage;

            if (Health < 0) { Health = 0; }

            lastDefense.UpdateInfo(damage, reduction);      
        }

    }
}