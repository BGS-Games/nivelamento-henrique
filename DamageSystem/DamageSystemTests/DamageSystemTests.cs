using NUnit.Framework;
using static System.Net.Mime.MediaTypeNames;

namespace DamageSystem.Tests
{
    public class DamageSystemTests
    {
        [Test]
        public void Given_character_should_calculate_damage_reduction()
        {
            var damageSystem = new DamageSystem();
            var character = CharacterMockBuilder.Simple();
            character.Equipment = 15;
            
            var damageReduction = damageSystem.CalculateDamageReduction(character);            

            Assert.That(damageReduction, Is.EqualTo(25));
        }

        [Test]
        public void Given_attack_should_execute_damage()
        {
            var damageSystem = new DamageSystem();            
            var attacker = CharacterMockBuilder.Simple();
            var defender = CharacterMockBuilder.Simple();

            damageSystem.ExecuteDamage(attacker, defender);

            Assert.That(defender.Health, Is.EqualTo(1));
        }

        //talvez esse teste deveria estar dentro de uma classe Gameplay
        [Test]
        public void Given_attack_print_damage_information()
        {
            var damageSystem = new DamageSystem(); 
            var attacker = CharacterMockBuilder.Simple();
            var defender = CharacterMockBuilder.Simple();

            //seria mais interessante isso não ser retornado, apenas printado
            //eu consigo colocar um assert em cima disso ?
            var attackInfo = damageSystem.ExecuteDamage(attacker, defender);

            Assert.That(attackInfo, Is.EqualTo("Personagem sofreu 9 de dano. (redução de 10%)"));
        }
    }
}
