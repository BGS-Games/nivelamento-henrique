using DamageSystem.DamageSystem;
using NUnit.Framework;
using static System.Net.Mime.MediaTypeNames;

namespace DamageSystem.Tests
{
    public class DamageSystemTests
    {
        [Test]
        public void Given_character_should_calculate_damage_reduction()
        {
            var damageSystem = new SimpleDamageSystem();
            var character = CharacterMockBuilder.Simple();
            character.Equipment = 15;
            
            var damageReduction = damageSystem.CalculateDamageReduction(character);            

            Assert.That(damageReduction, Is.EqualTo(25));
        }

        [Test]
        public void Given_attack_should_execute_damage()
        {
            var damageSystem = new SimpleDamageSystem();            
            var attacker = CharacterMockBuilder.Simple();
            var defender = CharacterMockBuilder.Simple();

            damageSystem.ExecuteDamage(attacker, defender);

            Assert.That(defender.Health, Is.EqualTo(1));
        }
    }
}
