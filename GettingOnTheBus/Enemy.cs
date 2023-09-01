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
        private readonly int regularSpeed = 1;

        public float Speed {get; set;}
        
        public Enemy (int enemyNumber)
        {
            this.enemyNumber = enemyNumber;
            this.Speed = 0;
        }

        public void Handle(IEvent currentEvent)
        {
            if (currentEvent.EventType == "SpeedItem")
            {
                UpdateSpeed(currentEvent.GetData());
            }
        }

        public void UpdateSpeed(ISpeedChanger speedChanger)
        {
            if (speedChanger.SpeedCoeff == 0)
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
