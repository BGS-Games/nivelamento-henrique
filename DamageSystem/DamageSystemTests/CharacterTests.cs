using NUnit.Framework;

namespace DamageSystem.Tests
{
    public class CharacterTests
    {
        [Test]
        public void Should_not_be_dead_when_health_is_greater_that_zero()
        {
            var character = CharacterMockBuilder.Simple();

            Assert.That(character.IsDead, Is.False);
        }

        [Test]
        public void When_initialized_should_not_allow_health_zero()
        {
            Assert.Throws<ArgumentException>(() => CharacterMockBuilder.Dead());
        }

        [Test]
        public void Should_be_able_to_equip_and_unequip()
        {
            var character = CharacterMockBuilder.Simple();
            character.Equipment = 10;

            Assert.That(character.Equipment, Is.EqualTo(10));
            
            character.Equipment = 0;

            Assert.That(character.Equipment, Is.EqualTo(0));
        }

        //public void Given_Damage_Should_Print_Characters_Health()
        //{

        //}
    }
}
