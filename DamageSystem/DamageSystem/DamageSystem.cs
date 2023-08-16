using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageSystem
{
    public class DamageSystem
    {
        public int CalculateDamageReduction(Character character)
        {
            return character.Defense + character.Equipment;
        }

        public string ExecuteDamage(Character attacker, Character defender)
        {
            var reduction = CalculateDamageReduction(attacker);
            var damage = attacker.Attack * ( 1 - reduction/100f);
            defender.TakeDamage((int) damage);

            //var attackInfo = string.Format("Personagem sofreu ${0} de dano. (redução de {1}%)", (int)damage, reduction);
            var attackInfo = $"Personagem sofreu {(int)damage} de dano. (redução de {reduction}%)";

            return attackInfo;
        }
    }
}
