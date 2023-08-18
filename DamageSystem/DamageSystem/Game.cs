namespace DamageSystem
{
    public class Game
    {
        private readonly IDisplay display;
        private readonly GameInfo gameInfo;

        public Game(IDisplay display)
        {
            this.display = display;
            gameInfo = new GameInfo();
        }

        public void Start()
        {
            display.WriteLine(gameInfo.PlayRound());
        }
    }
}