namespace DamageSystem
{
    public class Game
    {
        private readonly IDisplay display;
        public readonly GameInfo gameInfo;

        public Game(IDisplay display)
        {
            this.display = display;
            gameInfo = new GameInfo();
        }

        public void Start(GameObjects gameObjects)
        {
            PlayWholeGame(gameObjects);            
        }

        public void PlayWholeGame(GameObjects gameObjects)
        {
            while(gameObjects.defender.Health > 0)
            {
                PlayRound(gameObjects);

                display.WriteLine(gameInfo.roundInfo);
                display.WriteLine(gameInfo.attackInfo);
                display.WriteLine(gameInfo.defenseInfo);
                display.WriteLine(gameInfo.defenderLifeStatus);
            }
        }

        public void PlayRound(GameObjects gameObjects) 
        {
            gameObjects.UpdateNumberRound();
            gameObjects.damageSystem.ExecuteDamage(gameObjects.attacker, gameObjects.defender);
            
            gameInfo.AllInfoRoundUpdate(gameObjects);
        }

    }
}