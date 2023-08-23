using DamageSystem.Display;
using DamageSystem.Game;

var consoleDisplay = new ConsoleDisplay();
var game = new GameController(consoleDisplay);

GameInitializer gameObjects = new GameInitializer("Dumbledore", "Voldemort");

game.Start(gameObjects);