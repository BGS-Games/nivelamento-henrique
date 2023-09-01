
using GettingOnTheBus;

Enemy enemy1 = new(1);
Enemy enemy2 = new(2);
Enemy enemy3 = new(3);

EventBus eventBus = new();

eventBus.Register(enemy1);
eventBus.Register(enemy2);
eventBus.Register(enemy3);

SpeedItem cheetahBite = new(1.3f);
SpeedItem normalizer = new(0);
SpeedItem slothDrop = new(0.3f);

//player got the item sloth drop
eventBus.Dispatch(slothDrop);

//player got the item normalizer
eventBus.Dispatch(normalizer);

//player got the item normalizer
eventBus.Dispatch(cheetahBite);