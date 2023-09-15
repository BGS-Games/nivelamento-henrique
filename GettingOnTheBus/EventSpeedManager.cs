using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GettingOnTheBus
{
    public class EventSpeedManager : Singleton<EventSpeedManager>, ISubscribable 
    {
        public int RegularSpeed { get; } = 1;
        public float Speed { get; set; }

        public List<Enemy> EnemyList = new();               

        public void RegisterEnemy(Enemy enemy)
        {
            EnemyList.Add(enemy);
        }

        public void UpdateEnemySpeed()
        {
            foreach(Enemy e in EnemyList)
            {
                e.UpdateSpeed();
            }
        }

        public void Handle(IEvent currentEvent)
        {
            if(currentEvent is ISpeedChanger item)
            {
                UpdateSpeed(item);
                UpdateEnemySpeed();
            }
        }        

        public void UpdateSpeed(ISpeedChanger speedChanger)
        {
            if(speedChanger.SpeedCoeff == 0)
            {
                Speed = RegularSpeed;
            }
            else
            {
                Speed = RegularSpeed * speedChanger.SpeedCoeff;
            }            
        }
    }
}
