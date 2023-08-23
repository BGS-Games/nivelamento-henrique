namespace DamageSystem.Game
{
    public class GameInfoData
    {
        public string RoundInfo { get; }
        public string AttackInfo { get; }
        public string DefenseInfo { get; }
        public string DefenderLifeStatus { get; }

        public GameInfoData(
            string roundInfo, string attackInfo, string defenseInfo, string defenderLifeStatus
        )
        {
            RoundInfo = roundInfo;
            AttackInfo = attackInfo;
            DefenseInfo = defenseInfo;
            DefenderLifeStatus = defenderLifeStatus;
        }
    }
}