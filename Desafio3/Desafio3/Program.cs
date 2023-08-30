
using Desafio3;

EnemySubscriptionManager enemySubscriptionManager = new EnemySubscriptionManager();

//inscreve todos inimigos na lista
Enemy enemy = new(0);
enemySubscriptionManager.SubcribeEnemy(enemy);

Enemy enemy1 = new(1);
enemySubscriptionManager.SubcribeEnemy(enemy1);

Enemy enemy2 = new(2);
enemySubscriptionManager.SubcribeEnemy(enemy2);

//item é coletado - notifica todos inimigos 
Item nosTurbo = new(2.5f);
enemySubscriptionManager.ItemCollected(nosTurbo);

//remove o inimigo 1 da lista 
enemySubscriptionManager.UnsubscribeEnemy(enemy1);

//outro item é coletado - notifica todos inimigos da lista atual
Item normalizer = new(0);
enemySubscriptionManager.ItemCollected(normalizer);

//remove o inimigo 2 da lista 
enemySubscriptionManager.UnsubscribeEnemy(enemy2);

//outro item é coletado - notifica único inimigo atual
Item slowMo = new(0.6f);
enemySubscriptionManager.ItemCollected(slowMo);






