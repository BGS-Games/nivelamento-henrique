using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingOnTheBus
{
    public class Enemy 
    {
        private readonly int enemyNumber;
                
        public float Speed { get; set; }

        public Enemy(int enemyNumber)
        {
            this.enemyNumber = enemyNumber;            
            this.Speed = EventSpeedManager.Instance.RegularSpeed;            
            EventSpeedManager.Instance.RegisterEnemy(this);
        }

        
        public void PrintCurrentSpeed()
        {
            Console.WriteLine("Inimigo " + enemyNumber + "# tem velocidade atual de " + Speed);
        }

        internal void UpdateSpeed()
        {
            Speed = EventSpeedManager.Instance.Speed;
            PrintCurrentSpeed();
        }
    }
}
