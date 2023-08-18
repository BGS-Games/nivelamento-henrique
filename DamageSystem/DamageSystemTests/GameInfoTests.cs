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
        public void Given_a_round_should_print_rounds_value_in_first_line()
        {
            var gameInfo = new GameInfo();
            var roundInfo = gameInfo.PlayRound();            

            Assert.That(roundInfo, Is.EqualTo("Rodada #1"));

            roundInfo = gameInfo.PlayRound();

            Assert.That(roundInfo, Is.EqualTo("Rodada #2"));            
        }

        [Test]
        public void When_game_starts_runs_rounds_until_deffenders_life_is_zero()
        {
            var gameInfo = new GameInfo();
            gameInfo.StartGame(); 

            Assert.That(gameInfo.defender.Health, Is.EqualTo(0));
        }
    }
}
