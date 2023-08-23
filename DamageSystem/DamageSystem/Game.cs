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

                display.WriteLine(gameInfo.RoundInfo);
                display.WriteLine(gameInfo.AttackInfo);
                display.WriteLine(gameInfo.DefenseInfo);
                display.WriteLine(gameInfo.DefenderLifeStatus);
            }
        }

        public void PlayRound(GameObjects gameObjects) 
        {
            gameObjects.UpdateNumberRound();
            gameObjects.damageSystem.ExecuteDamage(gameObjects.attacker, gameObjects.defender);
            
            gameInfo.UpdateAllInfoRound(gameObjects);
        }

    }
}