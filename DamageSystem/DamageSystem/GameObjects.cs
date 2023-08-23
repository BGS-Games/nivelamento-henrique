using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageSystem
{
    public class GameObjects    
    {
        public Character attacker;
        public Character defender;
        public DamageSystem damageSystem = new DamageSystem();
        public int numberRound = 0;

        public GameObjects(string nameCharacter1, string nameCharacter2) 
        {
            attacker = new Character(new CharacterAttributes(nameCharacter1, 100, 30, 10));
            defender = new Character(new CharacterAttributes(nameCharacter2, 100, 30, 10));                    
        }

        public void UpdateNumberRound()
        {
            numberRound++;
        }
    }

}
