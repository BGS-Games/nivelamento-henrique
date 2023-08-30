using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    public class Enemy : IEnemyUpdater
    {
        private readonly int enemyNumber;
        public float Speed { get; set; }
        private readonly int regularSpeed = 1;
        
        public Enemy(int enemyNumber)
        {
            this.enemyNumber = enemyNumber;
            this.Speed = regularSpeed;
        }

        public void UpdateSpeed(float coeff)        
        {
            if (coeff == 0)
            {
                Speed = regularSpeed; 
            }
            else
            {
                Speed = regularSpeed*coeff;
            }            

            Console.WriteLine("Velocidade do Inimigo " + enemyNumber + " mudou.");
            PrintCurrentSpeed();
        }

        public void PrintCurrentSpeed()
        {
            Console.WriteLine("Inimigo " + enemyNumber + " tem velocidade atual de " + Speed);
        }
    }
}
