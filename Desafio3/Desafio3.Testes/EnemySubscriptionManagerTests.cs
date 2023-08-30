using NUnit.Framework;

namespace Desafio3.Testes
{    
    public class EnemySubscriptionManagerTests
    {
        [Test]
        public void Given_item_collected_enemy_should_change_speed()
        {
            EnemySubscriptionManager enemySubscriptionManager = new();
            Enemy enemy = new(0);
            Item fastItem = new(1.4f);
            Item fasterItem = new(2f);

            enemySubscriptionManager.SubcribeEnemy(enemy);
            enemySubscriptionManager.ItemCollected(fastItem);

            Assert.That(enemy.Speed, Is.EqualTo(1.4f));

            enemySubscriptionManager.ItemCollected(fasterItem);

            Assert.That(enemy.Speed, Is.EqualTo(2.8f));
        }

        //Given_IEnemyUpdater_subscription_should_add_into_updater_list
        //Given_IEnemyUpdater_unsubscription_should_remove_from_updater_list
        //Given_ISpeedChanger_should_notify_all_IEnemyUpdater_subscribed
    }
}