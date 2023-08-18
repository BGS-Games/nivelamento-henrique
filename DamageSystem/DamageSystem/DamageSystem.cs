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
            //eu teria que testar essa linha também  ? onde que isso tá sendo 
            Console.WriteLine(attacker.Name + " ataca");

            var reduction = CalculateDamageReduction(attacker);           
            
            var damage = attacker.Attack * ( 1 - reduction/100f);
            
            defender.TakeDamage((int) damage);

            //eu teria que testar essa linha também  ?
            Console.WriteLine($"{defender.Name} sofreu {(int)damage} de dano. (redução de {reduction}%)");     
        }
    }
}
