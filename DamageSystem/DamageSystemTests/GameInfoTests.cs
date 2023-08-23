using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageSystem.Tests
{
    internal class GameInfoTests
    {        
        [Test]
        public void Given_a_round_should_format_info_to_display()
        {
            var display = new StringDisplay();
            var game = new Game(display);
            GameObjects gameObjects = new GameObjects("Skywalker", "Darth Vader");
            
            game.PlayRound(gameObjects);
            var roundInfo = game.gameInfo.roundInfo; 

            Assert.That(roundInfo, Is.EqualTo("Rodada #1"));

            game.PlayRound(gameObjects);
            roundInfo = game.gameInfo.roundInfo;

            Assert.That(roundInfo, Is.EqualTo("Rodada #2"));
        }

    }
}
