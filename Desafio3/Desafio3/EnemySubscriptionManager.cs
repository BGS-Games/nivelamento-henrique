using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    public class EnemySubscriptionManager
    {

        readonly List<IEnemyUpdater> allEnemiesSubscripted; 

        public EnemySubscriptionManager()
        {
            allEnemiesSubscripted = new();
        }

        public void SubcribeEnemy (IEnemyUpdater enemy)
        {
            allEnemiesSubscripted.Add(enemy);
            Console.WriteLine("Inimigo foi inscrito na lista de eventos");
        }

        public void UnsubscribeEnemy (IEnemyUpdater enemy) 
        {
            allEnemiesSubscripted.Remove(enemy);
            Console.WriteLine("Inimigo foi removido da lista de eventos");
        }

        public void ItemCollected (ISpeedChanger item)
        {
            Console.WriteLine("Item foi coletado pelo palyer");

            NotifyEnemies(item.SpeedChanger);
        }

        public void NotifyEnemies (float currentEvent)
        {
            foreach (IEnemyUpdater e in allEnemiesSubscripted)
            {
                e.UpdateSpeed(currentEvent); 
            }
        }
    }
}
