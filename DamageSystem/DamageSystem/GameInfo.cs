
using System.Diagnostics;

namespace DamageSystem
{
    //talvez GamePlay teria sido um nome melhor
    public class GameInfo
    {
        public Character attacker = new Character (new CharacterAttributes("Dumbledor",100,30,10)); 
        public Character defender = new Character (new CharacterAttributes("Voldermort",100, 30, 10)); 
        public DamageSystem damageSystem = new DamageSystem();
        public int numberRound = 0;

        public string PlayRound()
        {
            numberRound++;
            
            var roundInfo = "Rodada #" + numberRound;
            Console.WriteLine("\n"+roundInfo);

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