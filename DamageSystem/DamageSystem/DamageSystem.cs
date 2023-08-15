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

        public void ExecuteDamage(Character attacker, Character defender)
        {
            var damage = attacker.Attack * ( 1 - CalculateDamageReduction(defender)/100f);
            defender.TakeDamage((int) damage);
        }
    }
}
