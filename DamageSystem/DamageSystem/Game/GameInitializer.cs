using DamageSystem.Character;
using DamageSystem.DamageSystem;

namespace DamageSystem.Game
{
    public class GameInitializer
    {
        public readonly IDamageSystem damageSystem;
        public CharacterController attacker;
        public CharacterController defender;
        public int numberRound = 0;

        public GameInitializer(string nameCharacter1, string nameCharacter2, IDamageSystem damageSystem)
        {
            attacker = new CharacterController(new CharacterAttributes(nameCharacter1, 100, 30, 10));
            defender = new CharacterController(new CharacterAttributes(nameCharacter2, 100, 30, 10));
            this.damageSystem = damageSystem;
        }

        public void UpdateNumberRound()
        {
            numberRound++;
        }
    }

}
