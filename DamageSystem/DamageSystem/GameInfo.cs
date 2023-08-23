
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace DamageSystem
{
    //TODO: Bruno - implementar a criação do game informa como um builder
    public class GameInfo
    {
        private string roundInfo = "Rodada 0";
        private string attackInfo = "No Attack";
        private string defenseInfo = "No Defense";
        private string defenderLifeStatus = "Defender is still Alive";

        public string RoundInfo { get => roundInfo; private set => roundInfo = value; }
        public string AttackInfo { get => attackInfo; private set => attackInfo = value; }
        public string DefenseInfo { get => defenseInfo; private set => defenseInfo = value; }
        public string DefenderLifeStatus { get => defenderLifeStatus; private set => defenderLifeStatus = value; }

        public void UpdateAllInfoRound(GameObjects gameObjects)
        {
            RoundInfoUpdate(gameObjects);
            AttackInfoUpdate(gameObjects);
            DefenseInfoUpdate(gameObjects);
            DeffendersLifeUpdate(gameObjects);
        }

        public void RoundInfoUpdate(GameObjects gameObjects)
        {   
            RoundInfo = "Rodada #" + gameObjects.numberRound;           
        }        

        public void AttackInfoUpdate(GameObjects gameObjects) 
        {
            AttackInfo = gameObjects.attacker.Name + " ataca";
        }

        public void DefenseInfoUpdate(GameObjects gameObjects)
        {
            var name = gameObjects.defender.Name;
            var damage = gameObjects.defender.lastDefense.LastDamage;
            var reduction = gameObjects.defender.lastDefense.LastReduction;

            defenseInfo = $"{name} sofreu {damage} de dano. (redução de {reduction}%)";
        }

        public void DeffendersLifeUpdate(GameObjects gameObjects)
        {
            var health = gameObjects.defender.Health;
            var name = gameObjects.defender.Name;

            if( health < 0)
            {
                DefenderLifeStatus = name + " morreu.";
            }
            else
            {
                DefenderLifeStatus = name + " tem uma vida restante de " + health;
            }
        }

    }
}