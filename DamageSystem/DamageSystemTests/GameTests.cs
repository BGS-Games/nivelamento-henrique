using NUnit.Framework;

namespace DamageSystem.Tests
{
    public class GameTests {

        [Test]
        public void Should_display_game_information()
        {
            var display = new StringDisplay();
            var game = new Game(display);
            GameObjects gameObjects = new GameObjects("Skywalker", "Darth Vader");

            game.Start(gameObjects);

            Assert.That(display.GetLines()[0], Is.EqualTo("Rodada #1"));
        }

        [Test]
        public void When_game_starts_runs_rounds_until_deffenders_life_is_zero()
        {
            var display = new StringDisplay();
            var game = new Game(display);
            GameObjects gameObjects = new GameObjects("Skywalker", "Darth Vader");
            
            game.Start(gameObjects);

            Assert.That(gameObjects.defender.Health, Is.EqualTo(0));
        }
    }
}