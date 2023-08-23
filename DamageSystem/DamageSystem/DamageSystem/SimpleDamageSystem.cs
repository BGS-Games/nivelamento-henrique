using DamageSystem.Character;

namespace DamageSystem.DamageSystem
{
    public class SimpleDamageSystem : IDamageSystem
    {
        public int CalculateDamageReduction(CharacterController character)
        {
            return character.Defense + character.Equipment;
        }

        public void ExecuteDamage(CharacterController attacker, CharacterController defender)
        {
            var reduction = CalculateDamageReduction(attacker);

            var damage = attacker.Attack * (1 - reduction / 100f);

            defender.TakeDamage((int)damage, reduction);
        }
    }
}
