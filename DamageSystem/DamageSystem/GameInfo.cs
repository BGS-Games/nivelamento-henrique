
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace DamageSystem
{
    //TODO: Bruno - implementar a criação do game informa como um builder
    public class GameInfo
    {
        public string roundInfo = "Rodada 0";
        public string attackInfo = "No Attack";
        public string defenseInfo = "No Defense";
        public string defenderLifeStatus = "Defender is still Alive";


        public void AllInfoRoundUpdate(GameObjects gameObjects)
        {
            RoundInfoUpdate(gameObjects);
            AttackInfoUpdate(gameObjects);
            DefenseInfoUpdate(gameObjects);
            DeffendersLifeUpdate(gameObjects);
        }

        public void RoundInfoUpdate(GameObjects gameObjects)
        {   
            roundInfo = "Rodada #" + gameObjects.numberRound;           
        }        

        public void AttackInfoUpdate(GameObjects gameObjects) 
        {
            attackInfo = gameObjects.attacker.Name + " ataca";
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
                defenderLifeStatus = name + " morreu.";
            }
            else
            {
                defenderLifeStatus = name + " tem uma vida restante de " + health;
            }
        }

    }
}