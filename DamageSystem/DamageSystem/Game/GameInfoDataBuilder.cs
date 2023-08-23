using DamageSystem.Character;

namespace DamageSystem.Game
{
    public class GameInfoDataBuilder
    {
        private string roundInfo = "Rodada 0";
        private string attackInfo = "No Attack";
        private string defenseInfo = "No Defense";
        private string defenderLifeStatus = "Defender is still Alive";

        public GameInfoDataBuilder WithRound(int round)
        {
            roundInfo = "Rodada #" + round;
            return this;
        }

        public GameInfoDataBuilder WithAttacker(CharacterController attacker)
        {
            attackInfo = attacker.Name + " ataca";
            return this;
        }

        public GameInfoDataBuilder WithDefender(CharacterController defender)
        {
            var name = defender.Name;
            var health = defender.Health;
            var damage = defender.lastDefense.LastDamage;
            var reduction = defender.lastDefense.LastReduction;

            defenseInfo = $"{name} sofreu {damage} de dano. (redução de {reduction}%)";

            if(health < 0)
            {
                defenderLifeStatus = name + " morreu.";
            }
            else
            {
                defenderLifeStatus = name + " tem uma vida restante de " + health;
            }

            return this;
        }

        public GameInfoData Build()
        {
            return new GameInfoData(roundInfo, attackInfo, defenseInfo, defenderLifeStatus);
        }
    }
}