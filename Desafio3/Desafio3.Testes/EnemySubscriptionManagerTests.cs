using NUnit.Framework;

namespace Desafio3.Testes
{    
    public class EnemySubscriptionManagerTests
    {
        [Test]
        public void Given_item_collected_enemy_subscripted_should_change_speed()
        {
            EnemySubscriptionManager enemySubscriptionManager = new();
            Enemy enemy = new(0);
            Item fastItem = new(1.4f);
            Item fasterItem = new(2f);

            enemySubscriptionManager.SubcribeEnemy(enemy);
            enemySubscriptionManager.ItemCollected(fastItem);

            Assert.That(enemy.Speed, Is.EqualTo(fastItem.SpeedChanger));

            enemySubscriptionManager.ItemCollected(fasterItem);

            Assert.That(enemy.Speed, Is.EqualTo(2f));
        }
    }
}