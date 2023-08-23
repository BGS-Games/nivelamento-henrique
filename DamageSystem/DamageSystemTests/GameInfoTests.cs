using DamageSystem.Display;
using DamageSystem.Game;
using NUnit.Framework;

namespace DamageSystem.Tests
{
    internal class GameInfoTests
    {
        [Test]
        public void Given_a_round_should_format_info_to_display()
        {
            var display = new StringDisplay();
            var game = new GameController(display);
            GameInitializer gameObjects = new GameInitializer("Skywalker", "Darth Vader");

            game.PlayRound(gameObjects);
            var roundInfo = game.gameInfo.RoundInfo;

            Assert.That(roundInfo, Is.EqualTo("Rodada #1"));

            game.PlayRound(gameObjects);
            roundInfo = game.gameInfo.RoundInfo;

            Assert.That(roundInfo, Is.EqualTo("Rodada #2"));
        }

    }
}
