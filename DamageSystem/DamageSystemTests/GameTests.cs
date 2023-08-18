using NUnit.Framework;

namespace DamageSystem.Tests
{
    public class GameTests {
        [Test]
        public void Should_display_game_information()
        {
            var display = new StringDisplay();
            var game = new Game(display);

            game.Start();

            Assert.That(display.GetLines()[0], Is.EqualTo("Rodada #1"));
        }
    }
}