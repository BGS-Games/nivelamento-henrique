using DamageSystem;

var consoleDisplay = new ConsoleDisplay();
var game = new Game(consoleDisplay);

GameObjects gameObjects = new GameObjects("Dumbledore", "Voldemort");

game.Start(gameObjects);