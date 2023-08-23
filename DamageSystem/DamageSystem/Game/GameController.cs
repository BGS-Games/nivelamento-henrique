using DamageSystem.Display;

namespace DamageSystem.Game
{
    public class GameController
    {
        private readonly IDisplay display;

        public GameController(IDisplay display)
        {
            this.display = display;
        }

        public void Start(GameInitializer gameObjects)
        {
            PlayWholeGame(gameObjects);
        }

        public void PlayWholeGame(GameInitializer gameObjects)
        {
            while(gameObjects.defender.Health > 0)
            {
                PlayRound(gameObjects);

                var gameInfo = new GameInfoDataBuilder()
                    .WithRound(gameObjects.numberRound)
                    .WithAttacker(gameObjects.attacker)
                    .WithDefender(gameObjects.defender)
                    .Build();

                display.WriteLine(gameInfo.RoundInfo);
                display.WriteLine(gameInfo.AttackInfo);
                display.WriteLine(gameInfo.DefenseInfo);
                display.WriteLine(gameInfo.DefenderLifeStatus);
            }
        }

        public void PlayRound(GameInitializer gameObjects)
        {
            gameObjects.UpdateNumberRound();
            gameObjects.damageSystem.ExecuteDamage(gameObjects.attacker, gameObjects.defender);
        }
    }
}