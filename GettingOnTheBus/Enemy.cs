using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingOnTheBus
{
    public class Enemy : ISubscribable
    {
        private readonly int enemyNumber;

        // TODO: EnemySpeedManager, referencias aos inimigos influenciados, singleton
        // criar um manager de velocidade que irá alterar a velocidade de cada inimigo registrado
        // criar uma classe abstrata do tipo singleton que o EnemySpeedManager irá herdar
        private readonly int regularSpeed = 1;

        public float Speed { get; set; }

        public Enemy(int enemyNumber)
        {
            this.enemyNumber = enemyNumber;
            this.Speed = 0;
            // exemplo de interface: EnemySpeedManager.Instance.Register(this);
        }

        public void Handle(IEvent currentEvent)
        {
            if(currentEvent.EventType == "SpeedItem")
                UpdateSpeed(currentEvent.GetData());
        }

        public void UpdateSpeed(ISpeedChanger speedChanger)
        {
            if(speedChanger.SpeedCoeff == 0)
            {
                Speed = regularSpeed;
            }
            else
            {
                Speed = regularSpeed * speedChanger.SpeedCoeff;
            }
        }

        public void PrintCurrentSpeed()
        {
            Console.WriteLine("Inimigo " + enemyNumber + "# tem velocidade atual de " + Speed);
        }
    }
}
