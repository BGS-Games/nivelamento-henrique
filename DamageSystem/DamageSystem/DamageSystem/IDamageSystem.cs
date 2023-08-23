using DamageSystem.Character;

namespace DamageSystem.DamageSystem
{
    public interface IDamageSystem
    {
        int CalculateDamageReduction(CharacterController character);
        void ExecuteDamage(CharacterController attacker, CharacterController defender);
    }
}
