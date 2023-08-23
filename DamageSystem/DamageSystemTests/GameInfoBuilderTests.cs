using DamageSystem.Display;
using DamageSystem.Game;
using NUnit.Framework;

namespace DamageSystem.Tests
{
    internal class GameInfoBuilderTests
    {
        [Test]
        public void Given_a_round_should_format_info()
        {
            var gameInfo = new GameInfoDataBuilder()
                .WithRound(1)
                .Build();


            Assert.That(gameInfo.RoundInfo, Is.EqualTo("Rodada #1"));
        }
    }
}
