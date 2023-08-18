
using System.Diagnostics;

namespace DamageSystem
{
    //TODO: Bruno - implementar a criação do game informa como um builder
    public class GameInfo
    {
        // TODO: essas iniicializações devem ser feitas no Program
        public Character attacker = new Character (new CharacterAttributes("Dumbledor",100,30,10)); 
        public Character defender = new Character (new CharacterAttributes("Voldermort",100, 30, 10)); 
        public DamageSystem damageSystem = new DamageSystem();
        public int numberRound = 0;

        public string PlayRound()
        {
            numberRound++;
            
            var roundInfo = "Rodada #" + numberRound;

            damageSystem.ExecuteDamage(attacker, defender);     
            
            return roundInfo;
        }

        public void StartGame()
        {
            while (defender.Health > 0)
            {
                PlayRound();
            }
        }
    }
}