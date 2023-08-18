using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageSystem
{

    // TODO: pode ser abstraído como uma interface, criar uma outra implementação
    public class DamageSystem
    {
        public int CalculateDamageReduction(Character character)
        {
            return character.Defense + character.Equipment;
        }

        public void ExecuteDamage(Character attacker, Character defender)
        {
            //TODO: remover os console.writeline das áreas de lógica
            Console.WriteLine(attacker.Name + " ataca");

            var reduction = CalculateDamageReduction(attacker);           
            
            var damage = attacker.Attack * ( 1 - reduction/100f);
            
            defender.TakeDamage((int) damage);
            
            Console.WriteLine($"{defender.Name} sofreu {(int)damage} de dano. (redução de {reduction}%)");     
        }
    }
}
